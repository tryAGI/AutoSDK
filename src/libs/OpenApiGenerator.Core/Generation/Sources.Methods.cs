using System.Net.Http;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateEndPoint(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endPoint.Path))
        {
            return GenerateConstructors(endPoint);
        }
        
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    public partial class {endPoint.ClassName}
    {{
{GenerateMethod(endPoint)}
{GenerateExtensionMethod(endPoint)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateConstructors(
        EndPoint endPoint)
    {
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    public sealed partial class {endPoint.ClassName} : global::System.IDisposable
    {{
        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// Creates a new instance of the {endPoint.ClassName}.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name=""client""></param>
        /// <param name=""baseUri""></param>
        /// <exception cref=""global::System.ArgumentNullException""></exception>
        public {endPoint.ClassName}(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {{
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(""{endPoint.BaseUrl}"");
        }}

        /// <inheritdoc/>
        public void Dispose()
        {{
            _httpClient.Dispose();
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GenerateMethod(
        EndPoint endPoint)
    {
        var jsonSerializer = endPoint.JsonSerializerType.GetSerializer();
        var taskType = endPoint.Stream
            ? string.IsNullOrWhiteSpace(endPoint.ResponseType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.ResponseType}>"
            : string.IsNullOrWhiteSpace(endPoint.ResponseType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.ResponseType}>";
        var httpCompletionOption = endPoint.Stream
            ? nameof(HttpCompletionOption.ResponseHeadersRead)
            : nameof(HttpCompletionOption.ResponseContentRead);
        var cancellationTokenAttribute = endPoint.Stream
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        
        return $@" 
        /// <summary>
        /// {endPoint.Summary}
        /// </summary>
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        public async {taskType} {endPoint.MethodName}(
{endPoint.Properties.Where(x => x.ParameterLocation != null).Select(x => $@"
            {x.Type.CSharpType} {x.Name.ToParameterName()},").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType) ? " " : @$" 
            {endPoint.RequestType} request,")}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default)
        {{
{(string.IsNullOrWhiteSpace(endPoint.RequestType) ? " " : @" 
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));
")}
{(endPoint.JsonSerializerType == JsonSerializerType.NewtonsoftJson ? endPoint.Properties
    .Where(x => x is { ParameterLocation: not null, Type.EnumValues.Length: > 0 })
    .Select(x => $@"
            var {x.ArgumentName} = {x.Name.ToParameterName()} switch
            {{
{x.Type.Properties.Zip(x.Type.EnumValues, (property, value) => (Property: property, Value: value))
    .Select(y => $@"
                {x.Type.CSharpType}.{y.Property.ToPropertyName()} => ""{y.Value}"",").Inject()}
                _ => throw new global::System.NotImplementedException(""Enum value not implemented.""),
            }};").Inject() : " ")}
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.{endPoint.HttpMethod:G},
                requestUri: {endPoint.Path});
{(string.IsNullOrWhiteSpace(endPoint.RequestType) ? " " : $@" 
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: {jsonSerializer.GenerateSerializeCall(endPoint.RequestType, endPoint.JsonSerializerContext)},
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: ""application/json"");")}

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.{httpCompletionOption},
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
{(string.IsNullOrWhiteSpace(endPoint.ResponseType) || endPoint.Stream ? " " : $@"
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                {jsonSerializer.GenerateDeserializeCall(endPoint.ResponseType, endPoint.JsonSerializerContext)} ??
                throw new global::System.InvalidOperationException(""Response deserialization failed for \""{{content}}\"" "");")}
{(endPoint.Stream ? $@"
            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            using var reader = new global::System.IO.StreamReader(stream);

            while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {{
                var content = await reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                var streamedResponse = {jsonSerializer.GenerateDeserializeCall(endPoint.ResponseType, endPoint.JsonSerializerContext)} ??
                                       throw new global::System.InvalidOperationException(""Response deserialization failed for \""{{content}}\"" "");

                yield return streamedResponse;
            }}" : " ")}
        }}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateExtensionMethod(
        EndPoint endPoint)
    {
        if (string.IsNullOrWhiteSpace(endPoint.RequestType))
        {
            return " ";
        }
        
        var taskType = endPoint.Stream
            ? string.IsNullOrWhiteSpace(endPoint.ResponseType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.ResponseType}>"
            : string.IsNullOrWhiteSpace(endPoint.ResponseType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.ResponseType}>";
        var cancellationTokenAttribute = endPoint.Stream
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        var response = endPoint.Stream
            ? "var enumerable = "
            : string.IsNullOrWhiteSpace(endPoint.ResponseType)
                ? "await "
                : "return await ";
        var configureAwaitResponse = !endPoint.Stream
            ? ".ConfigureAwait(false)"
            : string.Empty;
        
        return $@"
        /// <summary>
        /// {endPoint.Summary}
        /// </summary>
{endPoint.Properties.Select(x => $@"
        /// <param name=""{x.Name.ToParameterName()}""></param>").Inject()}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        public async {taskType} {endPoint.MethodName}(
{endPoint.Properties.Select(x => $@"
            {x.Type.CSharpType} {x.Name.ToParameterName()},").Inject()}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default)
        {{
            var request = new {endPoint.RequestType}
            {{
{endPoint.Properties.Where(x => x.ParameterLocation == null).Select(x => $@"
                {x.Name} = {x.Name.ToParameterName()},").Inject()}
            }};

            {response}{endPoint.MethodName}(
{endPoint.Properties.Where(x => x.ParameterLocation != null).Select(x => $@"
                {x.Name.ToParameterName()}: {x.Name.ToParameterName()},").Inject()}
                request: request,
                cancellationToken: cancellationToken){configureAwaitResponse};
{(endPoint.Stream ? @"
            
            await foreach (var response in enumerable)
            {
                yield return response;
            }" : " ")}
        }}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
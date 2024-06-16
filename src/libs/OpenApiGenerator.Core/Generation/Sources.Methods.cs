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
        if (!string.IsNullOrWhiteSpace(endPoint.AuthorizationScheme))
        {
            return GenerateAuthorizationMethod(endPoint);
        }
        if (string.IsNullOrWhiteSpace(endPoint.Path))
        {
            return GenerateConstructors(endPoint);
        }

        var usings = endPoint.Properties.Any(x => x.Type.IsArray && x.ParameterExplode == true)
            ? "using System.Linq;\n"
            : "";
        
        return $@"{usings}
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

    public static string GetHttpMethod(string targetFramework, OperationType operationType)
    {
        targetFramework = targetFramework ?? throw new ArgumentNullException(nameof(targetFramework));
        
        if (operationType == OperationType.Patch &&
            (targetFramework.StartsWith("net4", StringComparison.OrdinalIgnoreCase) ||
            targetFramework.StartsWith("netstandard", StringComparison.OrdinalIgnoreCase)))
        {
            return "new global::System.Net.Http.HttpMethod(\"PATCH\")";
        }
        
        return $"global::System.Net.Http.HttpMethod.{operationType:G}";
    }
    
    public static string GenerateMethod(
        EndPoint endPoint)
    {
        var jsonSerializer = endPoint.Settings.JsonSerializerType.GetSerializer();
        var taskType = endPoint.Stream
            ? string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.ResponseType.CSharpType}>"
            : string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.ResponseType.CSharpType}>";
        var httpCompletionOption = endPoint.Stream
            ? nameof(HttpCompletionOption.ResponseHeadersRead)
            : nameof(HttpCompletionOption.ResponseContentRead);
        var cancellationTokenAttribute = endPoint.Stream
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        
        return $@" 
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
{endPoint.Properties.Where(x => x.ParameterLocation != null).Select(x => $@"
        /// <param name=""{x.ParameterName}""></param>").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? " " : @" 
        /// <param name=""request""></param>")}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        {(endPoint.IsDeprecated ? "[global::System.Obsolete(\"This method marked as deprecated.\")]" : " ")}
        public async {taskType} {endPoint.MethodName}(
{endPoint.Properties.Where(x => x.ParameterLocation != null).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? " " : @$" 
            {endPoint.RequestType.CSharpTypeWithoutNullability} request,")}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default)
        {{
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? " " : @" 
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));
")}
{(endPoint.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson ? endPoint.Properties
    .Where(x => x is { ParameterLocation: not null, Type.EnumValues.Length: > 0 })
    .Select(x => $@"
            var {x.ArgumentName} = {x.ParameterName} switch
            {{
{x.Type.Properties.Zip(x.Type.EnumValues, (property, value) => (Property: property, Value: value))
    .Select(y => $@"
                {x.Type.CSharpType}.{y.Property.ToPropertyName()} => ""{y.Value}"",").Inject()}
                _ => throw new global::System.NotImplementedException(""Enum value not implemented.""),
            }};").Inject() : " ")}
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: {GetHttpMethod(endPoint.Settings.TargetFramework, endPoint.HttpMethod)},
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + {endPoint.Path}, global::System.UriKind.RelativeOrAbsolute));
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? " " : $@" 
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: {jsonSerializer.GenerateSerializeCall(endPoint.RequestType, endPoint.Settings.JsonSerializerContext)},
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: ""application/json"");")}

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.{httpCompletionOption},
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
{(string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType) || endPoint.Stream ? " " : $@"
            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                {jsonSerializer.GenerateDeserializeCall(endPoint.ResponseType, endPoint.Settings.JsonSerializerContext)} ??
                throw new global::System.InvalidOperationException($""Response deserialization failed for \""{{__content}}\"" "");")}
{(endPoint.Stream ? $@"
            using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            using var reader = new global::System.IO.StreamReader(stream);

            while (!reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {{
                var __content = await reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                var streamedResponse = {jsonSerializer.GenerateDeserializeCall(endPoint.ResponseType, endPoint.Settings.JsonSerializerContext)} ??
                                       throw new global::System.InvalidOperationException($""Response deserialization failed for \""{{__content}}\"" "");

                yield return streamedResponse;
            }}" : " ")}
        }}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateExtensionMethod(
        EndPoint endPoint)
    {
        if (string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ||
            endPoint.RequestType.IsArray ||
            endPoint.RequestType.IsEnum)
        {
            return " ";
        }
        
        var taskType = endPoint.Stream
            ? string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.ResponseType.CSharpType}>"
            : string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.ResponseType.CSharpType}>";
        var cancellationTokenAttribute = endPoint.Stream
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        var response = endPoint.Stream
            ? "var enumerable = "
            : string.IsNullOrWhiteSpace(endPoint.ResponseType.CSharpType)
                ? "await "
                : "return await ";
        var configureAwaitResponse = !endPoint.Stream
            ? ".ConfigureAwait(false)"
            : string.Empty;
        
        return $@"
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
{endPoint.Properties.Where(static x => x is { IsDeprecated: false } or { IsRequired:true }).Select(x => $@"
        /// <param name=""{x.ParameterName}""></param>").Inject()}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        {(endPoint.IsDeprecated ? "[global::System.Obsolete(\"This method marked as deprecated.\")]" : " ")}
        public async {taskType} {endPoint.MethodName}(
{endPoint.Properties.Where(static x => x.IsRequired).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{endPoint.Properties.Where(static x => x is { IsRequired: false, IsDeprecated: false }).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName} = {x.ParameterDefaultValue},").Inject()}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default)
        {{
            var request = new {endPoint.RequestType.CSharpTypeWithoutNullability}
            {{
{endPoint.Properties.Where(x => x.ParameterLocation == null && (x.IsRequired || !x.IsDeprecated)).Select(x => $@"
                {(x.Name.StartsWith("request", StringComparison.Ordinal) ? x.Name.Replace("request", string.Empty) : x.Name)} = {x.ParameterName},").Inject()}
            }};

            {response}{endPoint.MethodName}(
{endPoint.Properties.Where(x => x.ParameterLocation != null).Select(x => $@"
                {x.ParameterName}: {x.ParameterName},").Inject()}
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
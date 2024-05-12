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
    public partial class {endPoint.ClassName} : global::System.IDisposable
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
        var taskType = string.IsNullOrWhiteSpace(endPoint.ResponseType)
            ? string.Empty
            : $"<{endPoint.ResponseType}>";
        
        return $@" 
        /// <summary>
        /// {endPoint.Summary}
        /// </summary>
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        public async global::System.Threading.Tasks.Task{taskType} {endPoint.MethodName}(
{(string.IsNullOrWhiteSpace(endPoint.RequestType) ? " " : @$" 
            {endPoint.RequestType} request,")}
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
{(string.IsNullOrWhiteSpace(endPoint.RequestType) ? " " : @" 
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));
")}
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.{endPoint.HttpMethod:G},
                requestUri: ""{endPoint.Path}"");
{(string.IsNullOrWhiteSpace(endPoint.RequestType) ? " " : $@" 
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: {jsonSerializer.GenerateSerializeCall(endPoint.RequestType)}(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: ""application/json"");")}

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
{(string.IsNullOrWhiteSpace(endPoint.ResponseType) ? " " : $@"
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                {jsonSerializer.GenerateDeserializeCall(endPoint.ResponseType)}(content) ??
                throw new global::System.InvalidOperationException(""Response deserialization failed for \""{{content}}\"" "");")}
        }}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
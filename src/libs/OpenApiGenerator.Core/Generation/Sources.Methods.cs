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
{(endPoint.HttpMethod == OperationType.Get ? GenerateGetMethod(endPoint) : " ")}
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

    public static string GenerateGetMethod(
        EndPoint endPoint)
    {
        var jsonSerializer = endPoint.JsonSerializerType.GetSerializer();
        
        return $@" 
        /// <summary>
        /// {endPoint.Summary}
        /// </summary>
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        public async global::System.Threading.Tasks.Task<{endPoint.ResponseType}> {endPoint.MethodName}(
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            using var response = await _httpClient.GetAsync(
                new global::System.Uri(""{endPoint.Path}"", global::System.UriKind.RelativeOrAbsolute),
                cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                {jsonSerializer.GenerateDeserializeCall(endPoint.ResponseType)}(content) ??
                throw new global::System.InvalidOperationException(""Response deserialization failed for \""{{content}}\"" "");
        }}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
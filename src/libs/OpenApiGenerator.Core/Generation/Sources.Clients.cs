using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateConstructors(
        EndPoint endPoint)
    {
        var serializer = endPoint.Settings.JsonSerializerType.GetSerializer();
        var hasOptions = string.IsNullOrWhiteSpace(endPoint.Settings.JsonSerializerContext);
        
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    {(endPoint.Summary + "\nIf no httpClient is provided, a new one will be created.\nIf no baseUri is provided, the default baseUri from OpenAPI spec will be used.").ToXmlDocumentationSummary()}
    public sealed partial class {endPoint.ClassName} : global::System.IDisposable
    {{
        {endPoint.BaseUrlSummary.ToXmlDocumentationSummary(level: 8)}
        public const string BaseUrl = ""{endPoint.BaseUrl}"";

        private readonly global::System.Net.Http.HttpClient _httpClient;
{(hasOptions ? $@" 
        private readonly {serializer.GetOptionsType()} _jsonSerializerOptions;" : " ")}

{(endPoint.Properties.Length != 0 ? "\n" + endPoint.Properties.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
        public {x.Type.CSharpType} {x.Name} => new {x.Type.CSharpType}(_httpClient{(hasOptions ? ", jsonSerializerOptions: _jsonSerializerOptions" : "")});
").Inject() : " ")}

        /// <summary>
        /// Creates a new instance of the {endPoint.ClassName}.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name=""httpClient""></param>
        /// <param name=""baseUri""></param>{(hasOptions ? @"
        /// <param name=""jsonSerializerOptions""></param>" : " ")}
        public {endPoint.ClassName}(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null{(hasOptions ? $@",
            {serializer.GetOptionsType()}? jsonSerializerOptions = null" : " ")}
            )
        {{
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
{(hasOptions ? $@" 
            _jsonSerializerOptions = _jsonSerializerOptions ?? {(endPoint.Id == "MainConstructor" ? serializer.CreateDefaultSettings(endPoint.Converters) : $"new {serializer.GetOptionsType()}()")};" : " ")}
        }}

        /// <inheritdoc/>
        public void Dispose()
        {{
            _httpClient.Dispose();
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateAuthorizationMethod(
        EndPoint endPoint)
    {
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    public sealed partial class {endPoint.ClassName}
    {{
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""apiKey""></param>
        public void {endPoint.NotAsyncMethodName}(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _httpClient.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                scheme: ""{endPoint.AuthorizationScheme.ToPropertyName()}"",
                parameter: apiKey);
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
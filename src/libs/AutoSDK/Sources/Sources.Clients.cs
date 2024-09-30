using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateClient(
        Client client)
    {
        var serializer = client.Settings.JsonSerializerType.GetSerializer();
        var hasOptions = string.IsNullOrWhiteSpace(client.Settings.JsonSerializerContext);
        
        return $@"
#nullable enable

namespace {client.Namespace}
{{
    {(client.Summary + "\nIf no httpClient is provided, a new one will be created.\nIf no baseUri is provided, the default baseUri from OpenAPI spec will be used.").ToXmlDocumentationSummary()}
    public sealed partial class {client.ClassName} : global::{client.Namespace}.I{client.ClassName}, global::System.IDisposable
    {{
        {client.BaseUrlSummary.ToXmlDocumentationSummary(level: 8)}
        public const string BaseUrl = ""{client.BaseUrl}"";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::{client.Namespace}.EndPointAuthorization? _authorization;

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
{(hasOptions ? $@" 
        public {serializer.GetOptionsType()} JsonSerializerOptions {{ get; set; }}{(
            client.Id == "MainConstructor"
                ? $" = {serializer.CreateDefaultSettings(client.Converters)};"
                : $" = new {serializer.GetOptionsType()}();")}" : $@" 
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext {{ get; set; }} = global::{client.Settings.JsonSerializerContext}.Default;")}

{(client.Clients.Length != 0 ? "\n" + client.Clients.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
        public {x.Type.CSharpType} {x.Name} => new {x.Type.CSharpType}(_httpClient, authorization: _authorization)
        {{
            {(hasOptions
                ? "JsonSerializerOptions = JsonSerializerOptions,"
                : "JsonSerializerContext = JsonSerializerContext,")}
        }};
").Inject() : " ")}

        /// <summary>
        /// Creates a new instance of the {client.ClassName}.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name=""httpClient""></param>
        /// <param name=""baseUri""></param>{(hasOptions ? @"
        /// <param name=""jsonSerializerOptions""></param>" : " ")}
        public {client.ClassName}(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::{client.Namespace}.EndPointAuthorization? authorization = null)
        {{
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorization = authorization;

            Initialized(_httpClient);
        }}

        /// <inheritdoc/>
        public void Dispose()
        {{
            _httpClient.Dispose();
        }}

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    
    public static string GenerateClientInterface(
        Client client)
    {
        var serializer = client.Settings.JsonSerializerType.GetSerializer();
        var hasOptions = string.IsNullOrWhiteSpace(client.Settings.JsonSerializerContext);
        
        return $@"
#nullable enable

namespace {client.Namespace}
{{
    {(client.Summary + "\nIf no httpClient is provided, a new one will be created.\nIf no baseUri is provided, the default baseUri from OpenAPI spec will be used.").ToXmlDocumentationSummary()}
    public partial interface I{client.ClassName} : global::System.IDisposable
    {{
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
{(hasOptions ? $@" 
        {serializer.GetOptionsType()} JsonSerializerOptions {{ get; set; }}" : $@" 
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext {{ get; set; }}")}

{(client.Clients.Length != 0 ? "\n" + client.Clients.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
        public {x.Type.CSharpType} {x.Name} {{ get; }}
").Inject() : " ")}

    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
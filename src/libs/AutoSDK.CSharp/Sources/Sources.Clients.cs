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
        var hasOptions = !client.Settings.HasJsonSerializerContext();
        var rootClassName = client.Settings.ClassName.Replace(".", string.Empty);
        var suppressDeprecatedWarningsForJsonSerializerOptions =
            hasOptions &&
            client.Settings.UsesSystemTextJson() &&
            client.Id == "MainConstructor" &&
            client.Converters.Length != 0;
        
        return $@"
#nullable enable

namespace {client.Settings.Namespace}
{{
    {(client.Summary + "\nIf no httpClient is provided, a new one will be created.\nIf no baseUri is provided, the default baseUri from OpenAPI spec will be used.").ToXmlDocumentationSummary()}
    public sealed partial class {client.ClassName} : global::{client.Settings.Namespace}.I{client.ClassName}, global::System.IDisposable
    {{
        {client.BaseUrlSummary.ToXmlDocumentationSummary(level: 8)}
        public const string DefaultBaseUrl = ""{client.BaseUrl}"";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient {{ get; }}

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::{client.GlobalSettings.Namespace}.EndPointAuthorization> Authorizations {{ get; }}

        /// <inheritdoc/>
        public bool ReadResponseAsString {{ get; set; }}
#if DEBUG
            = true;
#endif
{(client.HasIdempotencySupport ? @"

        /// <inheritdoc/>
        public global::System.Func<string> CreateIdempotencyKey { get; set; } = () => global::System.Guid.NewGuid().ToString(""D"");" : TrimmedLine)}
{(client.HasOAuth2Support ? $@"

        internal global::{client.Settings.Namespace}.{rootClassName}.AutoSDKOAuth2Coordinator AutoSDKOAuth2State {{ get; set; }} = new global::{client.Settings.Namespace}.{rootClassName}.AutoSDKOAuth2Coordinator();" : TrimmedLine)}
        
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
{(hasOptions ? $@" 
{(suppressDeprecatedWarningsForJsonSerializerOptions ? "        #pragma warning disable CS0618 // Type or member is obsolete" : TrimmedLine)}
        public {serializer.GetOptionsType()} JsonSerializerOptions {{ get; set; }}{(
            client.Id == "MainConstructor"
                ? $" = {serializer.CreateDefaultSettings(client.Converters)};"
                : $" = new {serializer.GetOptionsType()}();")}
{(suppressDeprecatedWarningsForJsonSerializerOptions ? "        #pragma warning restore CS0618 // Type or member is obsolete" : TrimmedLine)}" : $@" 
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext {{ get; set; }} = global::{client.Settings.JsonSerializerContext}.Default;")}

{(client.Clients.Length != 0 ? "\n" + client.Clients.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
        public {x.Type.CSharpType} {x.Name} => new {x.Type.CSharpType}(HttpClient, authorizations: Authorizations)
        {{
            ReadResponseAsString = ReadResponseAsString,
            {(client.HasIdempotencySupport ? "CreateIdempotencyKey = CreateIdempotencyKey," : TrimmedLine)}
            {(hasOptions
                ? "JsonSerializerOptions = JsonSerializerOptions,"
                : "JsonSerializerContext = JsonSerializerContext,")}
            {(client.HasOAuth2Support ? "AutoSDKOAuth2State = AutoSDKOAuth2State," : TrimmedLine)}
        }};
").Inject() : TrimmedLine)}

        /// <summary>
        /// Creates a new instance of the {client.ClassName}.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name=""httpClient"">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name=""baseUri"">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name=""authorizations"">The authorizations to use for the requests.</param>
        /// <param name=""disposeHttpClient"">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public {client.ClassName}(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::{client.GlobalSettings.Namespace}.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {{
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::{client.GlobalSettings.Namespace}.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }}

        /// <inheritdoc/>
        public void Dispose()
        {{
            if (_disposeHttpClient)
            {{
                HttpClient.Dispose();
            }}
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
        var hasOptions = !client.Settings.HasJsonSerializerContext();
        
        return $@"
#nullable enable

namespace {client.Settings.Namespace}
{{
    {(client.Summary + "\nIf no httpClient is provided, a new one will be created.\nIf no baseUri is provided, the default baseUri from OpenAPI spec will be used.").ToXmlDocumentationSummary()}
    public partial interface I{client.ClassName} : global::System.IDisposable
    {{
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient {{ get; }}

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri {{ get; }}

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::{client.GlobalSettings.Namespace}.EndPointAuthorization> Authorizations {{ get; }}

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref=""ApiException.ResponseBody""/> is populated.
        /// </summary>
        public bool ReadResponseAsString {{ get; set; }}

{(client.HasIdempotencySupport ? @"        /// <summary>
        /// Creates idempotency keys for generated idempotent requests when the caller does not provide one.
        /// </summary>
        public global::System.Func<string> CreateIdempotencyKey { get; set; }" : TrimmedLine)}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
{(hasOptions
    ? $@" 
        {serializer.GetOptionsType()} JsonSerializerOptions {{ get; set; }}"
    : $@" 
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext {{ get; set; }}")}

{(client.Clients.Length != 0 ? "\n" + client.Clients.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
        public {x.Type.CSharpType} {x.Name} {{ get; }}
").Inject() : TrimmedLine)}

    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}

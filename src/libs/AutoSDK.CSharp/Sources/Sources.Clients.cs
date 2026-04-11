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
        var hasServerSelection = client.Servers.Length > 1;
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
{((client.Id == "MainConstructor" && client.HasMutualTlsSupport) ? @"
        private readonly global::System.Net.Http.HttpClientHandler? _ownedHttpClientHandler;" : TrimmedLine)}

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient {{ get; }}

        /// <inheritdoc/>
        public System.Uri? BaseUri => {(hasServerSelection ? "ResolveDisplayedBaseUri()" : "HttpClient.BaseAddress")};

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::{client.GlobalSettings.Namespace}.EndPointAuthorization> Authorizations {{ get; }}

        /// <inheritdoc/>
        public bool ReadResponseAsString {{ get; set; }}
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::{client.Settings.Namespace}.AutoSDKClientOptions Options {{ get; }}
{(client.HasIdempotencySupport ? @"

        /// <inheritdoc/>
        public global::System.Func<string> CreateIdempotencyKey { get; set; } = () => global::System.Guid.NewGuid().ToString(""D"");" : TrimmedLine)}
{(client.HasOAuth2Support ? $@"

        internal global::{client.Settings.Namespace}.{rootClassName}.AutoSDKOAuth2Coordinator AutoSDKOAuth2State {{ get; set; }} = new global::{client.Settings.Namespace}.{rootClassName}.AutoSDKOAuth2Coordinator();" : TrimmedLine)}
{(client.UsesServerSelectionSupport ? $@"

        internal global::{client.Settings.Namespace}.AutoSDKServerConfiguration AutoSDKServerConfiguration {{ get; set; }} = new global::{client.Settings.Namespace}.AutoSDKServerConfiguration();" : TrimmedLine)}
        
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
        public {x.Type.CSharpType} {x.Name} => new {x.Type.CSharpType}(HttpClient, authorizations: Authorizations, options: Options)
        {{
            ReadResponseAsString = ReadResponseAsString,
            {(client.HasIdempotencySupport ? "CreateIdempotencyKey = CreateIdempotencyKey," : TrimmedLine)}
            {(hasOptions
                ? "JsonSerializerOptions = JsonSerializerOptions,"
                : "JsonSerializerContext = JsonSerializerContext,")}
            {(client.HasOAuth2Support ? "AutoSDKOAuth2State = AutoSDKOAuth2State," : TrimmedLine)}
            {(client.UsesServerSelectionSupport ? "AutoSDKServerConfiguration = AutoSDKServerConfiguration," : TrimmedLine)}
        }};
").Inject() : TrimmedLine)}
{(hasServerSelection ? $@"

        private static readonly global::{client.Settings.Namespace}.AutoSDKServer[] s_availableServers = new global::{client.Settings.Namespace}.AutoSDKServer[]
        {{{GenerateServerDeclarations(client.Servers, client.Settings.Namespace, 12)}
        }};

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::{client.Settings.Namespace}.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::{client.Settings.Namespace}.AutoSDKServer? SelectedServer
        {{
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }}" : TrimmedLine)}

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
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {{
        }}

        /// <summary>
        /// Creates a new instance of the {client.ClassName}.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name=""httpClient"">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name=""baseUri"">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name=""authorizations"">The authorizations to use for the requests.</param>
        /// <param name=""options"">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name=""disposeHttpClient"">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public {client.ClassName}(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::{client.GlobalSettings.Namespace}.EndPointAuthorization>? authorizations = null,
            global::{client.Settings.Namespace}.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {{
{((client.Id == "MainConstructor" && client.HasMutualTlsSupport) ? @"
            if (httpClient is null)
            {
                _ownedHttpClientHandler = new global::System.Net.Http.HttpClientHandler();
                _ownedHttpClientHandler.CheckCertificateRevocationList = true;
                HttpClient = new global::System.Net.Http.HttpClient(_ownedHttpClientHandler, disposeHandler: true);
            }
            else
            {
                HttpClient = httpClient;
            }" : @"
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();")}
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::{client.GlobalSettings.Namespace}.EndPointAuthorization>();
            Options = options ?? new global::{client.Settings.Namespace}.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;
{(client.UsesServerSelectionSupport ? @"
            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;" : TrimmedLine)}

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
{(hasServerSelection ? $@"

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {{
            if (string.IsNullOrWhiteSpace(serverId))
            {{
                return false;
            }}

            foreach (var server in s_availableServers)
            {{
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {{
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }}
            }}

            return false;
        }}

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {{
            AutoSDKServerConfiguration.SelectedServer = null;
        }}

        private global::{client.Settings.Namespace}.AutoSDKServer? ResolveSelectedServer()
        {{
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {{
                return null;
            }}

            foreach (var server in s_availableServers)
            {{
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {{
                    return server;
                }}
            }}

            return null;
        }}

        private void SelectServer(global::{client.Settings.Namespace}.AutoSDKServer? server)
        {{
            if (server is null)
            {{
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }}

            foreach (var candidate in s_availableServers)
            {{
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {{
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }}
            }}

            throw new global::System.ArgumentException(""The provided server is not available for this client."", nameof(server));
        }}

        private global::System.Uri? ResolveDisplayedBaseUri()
        {{
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {{
                return explicitBaseUri;
            }}

            return ResolveSelectedServer()?.Uri ?? HttpClient.BaseAddress;
        }}

        private global::System.Uri? ResolveBaseUri(
            global::{client.Settings.Namespace}.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {{
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {{
                return explicitBaseUri;
            }}

            if (AutoSDKServerConfiguration.SelectedServer is global::{client.Settings.Namespace}.AutoSDKServer selectedServer)
            {{
                foreach (var server in servers)
                {{
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {{
                        return server.Uri;
                    }}
                }}
            }}

            if (servers.Length > 0)
            {{
                return servers[0].Uri;
            }}

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }}" : TrimmedLine)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    
    public static string GenerateClientInterface(
        Client client)
    {
        var serializer = client.Settings.JsonSerializerType.GetSerializer();
        var hasOptions = !client.Settings.HasJsonSerializerContext();
        var hasServerSelection = client.Servers.Length > 1;
        
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
{(hasServerSelection ? $@"

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::{client.Settings.Namespace}.AutoSDKServer> AvailableServers {{ get; }}

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::{client.Settings.Namespace}.AutoSDKServer? SelectedServer {{ get; set; }}

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();" : TrimmedLine)}

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
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::{client.Settings.Namespace}.AutoSDKClientOptions Options {{ get; }}

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

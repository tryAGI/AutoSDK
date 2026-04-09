//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Browserbase API for 3rd party developers<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Public endpoint
        /// </summary>
        public const string DefaultBaseUrl = "https://api.browserbase.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.BrowserbaseProxyConfigTypeJsonConverter(),
                    new global::G.JsonConverters.BrowserbaseProxyConfigTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ExternalProxyConfigTypeJsonConverter(),
                    new global::G.JsonConverters.ExternalProxyConfigTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionBuildStatusJsonConverter(),
                    new global::G.JsonConverters.FunctionBuildStatusNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionBuildCauseCodeJsonConverter(),
                    new global::G.JsonConverters.FunctionBuildCauseCodeNullableJsonConverter(),
                    new global::G.JsonConverters.InvocationStatusJsonConverter(),
                    new global::G.JsonConverters.InvocationStatusNullableJsonConverter(),
                    new global::G.JsonConverters.NoneProxyConfigTypeJsonConverter(),
                    new global::G.JsonConverters.NoneProxyConfigTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SessionStatusJsonConverter(),
                    new global::G.JsonConverters.SessionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SessionRegionJsonConverter(),
                    new global::G.JsonConverters.SessionRegionNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOsJsonConverter(),
                    new global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOsNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeJsonConverter(),
                    new global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionJsonConverter(),
                    new global::G.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionNullableJsonConverter(),
                    new global::G.JsonConverters.SessionsCreateRequestBrowserSettingsOsJsonConverter(),
                    new global::G.JsonConverters.SessionsCreateRequestBrowserSettingsOsNullableJsonConverter(),
                    new global::G.JsonConverters.SessionsCreateRequestRegionJsonConverter(),
                    new global::G.JsonConverters.SessionsCreateRequestRegionNullableJsonConverter(),
                    new global::G.JsonConverters.SessionsUpdateRequestStatusJsonConverter(),
                    new global::G.JsonConverters.SessionsUpdateRequestStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SessionsListStatusJsonConverter(),
                    new global::G.JsonConverters.SessionsListStatusNullableJsonConverter(),
                    new global::G.JsonConverters.InvocationsGetResponseCauseCodeJsonConverter(),
                    new global::G.JsonConverters.InvocationsGetResponseCauseCodeNullableJsonConverter(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.Function, global::G.FunctionBuildBuiltFunction>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.Invocation, global::G.InvocationsGetResponse2>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.Session, global::G.SessionsCreateResponse2>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.Session, global::G.SessionsGetResponse2>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

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
    }
}
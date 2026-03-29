//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant2ValVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant2ValVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subdomain")]
        public string? Subdomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("your-domain")]
        public string? YourDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shop")]
        public string? Shop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_url")]
        public string? AccountUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("COMPANYDOMAIN")]
        public string? Companydomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("form_api_base_url")]
        public string? FormApiBaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceEndpoint")]
        public string? InstanceEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_url")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("borneo_dashboard_url")]
        public string? BorneoDashboardUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_username")]
        public string? ProxyUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_password")]
        public string? ProxyPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dc")]
        public string? Dc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_name")]
        public string? SiteName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceName")]
        public string? InstanceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("your_server")]
        public string? YourServer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_location")]
        public string? ServerLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant2StatusJsonConverter))]
        public global::G.GetConnectedAccountsResponseItemStateVariant2ValVariant2Status Status { get; set; }

        /// <summary>
        /// The oauth2 state prefix for the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_prefix")]
        public string? StatePrefix { get; set; }

        /// <summary>
        /// Whether to return the redirect url without shortening
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_redirect_url")]
        public bool? LongRedirectUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedirectUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalRedirectUri")]
        public string? FinalRedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_signature")]
        public string? WebhookSignature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant2ValVariant2" /> class.
        /// </summary>
        /// <param name="redirectUrl"></param>
        /// <param name="subdomain"></param>
        /// <param name="yourDomain"></param>
        /// <param name="region"></param>
        /// <param name="shop"></param>
        /// <param name="accountUrl"></param>
        /// <param name="companydomain"></param>
        /// <param name="extension"></param>
        /// <param name="formApiBaseUrl"></param>
        /// <param name="instanceEndpoint"></param>
        /// <param name="apiUrl"></param>
        /// <param name="borneoDashboardUrl"></param>
        /// <param name="proxyUsername"></param>
        /// <param name="proxyPassword"></param>
        /// <param name="domain"></param>
        /// <param name="version"></param>
        /// <param name="dc"></param>
        /// <param name="siteName"></param>
        /// <param name="instanceName"></param>
        /// <param name="accountId"></param>
        /// <param name="yourServer"></param>
        /// <param name="serverLocation"></param>
        /// <param name="baseUrl"></param>
        /// <param name="status"></param>
        /// <param name="statePrefix">
        /// The oauth2 state prefix for the connection
        /// </param>
        /// <param name="longRedirectUrl">
        /// Whether to return the redirect url without shortening
        /// </param>
        /// <param name="codeVerifier"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="finalRedirectUri"></param>
        /// <param name="webhookSignature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItemStateVariant2ValVariant2(
            string redirectUrl,
            string? subdomain,
            string? yourDomain,
            string? region,
            string? shop,
            string? accountUrl,
            string? companydomain,
            string? extension,
            string? formApiBaseUrl,
            string? instanceEndpoint,
            string? apiUrl,
            string? borneoDashboardUrl,
            string? proxyUsername,
            string? proxyPassword,
            string? domain,
            string? version,
            string? dc,
            string? siteName,
            string? instanceName,
            string? accountId,
            string? yourServer,
            string? serverLocation,
            string? baseUrl,
            global::G.GetConnectedAccountsResponseItemStateVariant2ValVariant2Status status,
            string? statePrefix,
            bool? longRedirectUrl,
            string? codeVerifier,
            string? callbackUrl,
            string? finalRedirectUri,
            string? webhookSignature)
        {
            this.Subdomain = subdomain;
            this.YourDomain = yourDomain;
            this.Region = region;
            this.Shop = shop;
            this.AccountUrl = accountUrl;
            this.Companydomain = companydomain;
            this.Extension = extension;
            this.FormApiBaseUrl = formApiBaseUrl;
            this.InstanceEndpoint = instanceEndpoint;
            this.ApiUrl = apiUrl;
            this.BorneoDashboardUrl = borneoDashboardUrl;
            this.ProxyUsername = proxyUsername;
            this.ProxyPassword = proxyPassword;
            this.Domain = domain;
            this.Version = version;
            this.Dc = dc;
            this.SiteName = siteName;
            this.InstanceName = instanceName;
            this.AccountId = accountId;
            this.YourServer = yourServer;
            this.ServerLocation = serverLocation;
            this.BaseUrl = baseUrl;
            this.Status = status;
            this.StatePrefix = statePrefix;
            this.LongRedirectUrl = longRedirectUrl;
            this.CodeVerifier = codeVerifier;
            this.RedirectUrl = redirectUrl ?? throw new global::System.ArgumentNullException(nameof(redirectUrl));
            this.CallbackUrl = callbackUrl;
            this.FinalRedirectUri = finalRedirectUri;
            this.WebhookSignature = webhookSignature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant2ValVariant2" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant2ValVariant2()
        {
        }
    }
}
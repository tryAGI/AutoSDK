//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3StatusJsonConverter))]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3Status Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token")]
        public string? IdToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, string, object>))]
        public global::G.AnyOf<double?, string, object>? ExpiresIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_signature")]
        public string? WebhookSignature { get; set; }

        /// <summary>
        /// for slack user scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authed_user")]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3AuthedUser? AuthedUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
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
        /// <param name="idToken"></param>
        /// <param name="tokenType"></param>
        /// <param name="refreshToken"></param>
        /// <param name="expiresIn"></param>
        /// <param name="scope"></param>
        /// <param name="webhookSignature"></param>
        /// <param name="authedUser">
        /// for slack user scopes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3(
            string accessToken,
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
            global::G.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3Status status,
            string? statePrefix,
            bool? longRedirectUrl,
            string? idToken,
            string? tokenType,
            string? refreshToken,
            global::G.AnyOf<double?, string, object>? expiresIn,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? scope,
            string? webhookSignature,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3AuthedUser? authedUser)
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
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.IdToken = idToken;
            this.TokenType = tokenType;
            this.RefreshToken = refreshToken;
            this.ExpiresIn = expiresIn;
            this.Scope = scope;
            this.WebhookSignature = webhookSignature;
            this.AuthedUser = authedUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3()
        {
        }
    }
}
//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val
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
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, string, object>))]
        public global::G.AnyOf<double?, string, object>? ExpiresIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
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
        /// <param name="tokenType"></param>
        /// <param name="expiresIn"></param>
        /// <param name="expiresAt"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val(
            string accessToken,
            string clientId,
            string clientSecret,
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
            string? tokenType,
            global::G.AnyOf<double?, string, object>? expiresIn,
            string? expiresAt,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? scope)
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
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.TokenType = tokenType;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.ExpiresIn = expiresIn;
            this.ExpiresAt = expiresAt;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val" /> class.
        /// </summary>
        public PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11Val()
        {
        }
    }
}
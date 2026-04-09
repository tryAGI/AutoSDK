//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant9ValVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subdomain")]
        public string? Subdomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("your-domain")]
        public string? YourDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shop")]
        public string? Shop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_url")]
        public string? AccountUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("COMPANYDOMAIN")]
        public string? Companydomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("form_api_base_url")]
        public string? FormApiBaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instanceEndpoint")]
        public string? InstanceEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_url")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("borneo_dashboard_url")]
        public string? BorneoDashboardUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxy_username")]
        public string? ProxyUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxy_password")]
        public string? ProxyPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dc")]
        public string? Dc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_name")]
        public string? SiteName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instanceName")]
        public string? InstanceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("your_server")]
        public string? YourServer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_location")]
        public string? ServerLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3StatusJsonConverter))]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("devKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string DevKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant9ValVariant3" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="devKey"></param>
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
        public PostConnectedAccountsResponseConnectionDataVariant9ValVariant3(
            string sessionId,
            string devKey,
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
            global::G.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3Status status)
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
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.DevKey = devKey ?? throw new global::System.ArgumentNullException(nameof(devKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant9ValVariant3" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant9ValVariant3()
        {
        }
    }
}
//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant8ValVariant2
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2StatusJsonConverter))]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2Status Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant8ValVariant2" /> class.
        /// </summary>
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
        public PostConnectedAccountsRequestConnectionStateVariant8ValVariant2(
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
            global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2Status status)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant8ValVariant2" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant8ValVariant2()
        {
        }
    }
}
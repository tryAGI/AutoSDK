//HintName: G.Models.ProviderCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderCreate
    {
        /// <summary>
        /// The name of the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProviderType ProviderType { get; set; } = default!;

        /// <summary>
        /// API key or secret key used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// Access key used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_key")]
        public string? AccessKey { get; set; }

        /// <summary>
        /// Region used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Base URL used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// API version used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the provider.
        /// </param>
        /// <param name="providerType">
        /// The type of the provider.
        /// </param>
        /// <param name="apiKey">
        /// API key or secret key used for requests to the provider.
        /// </param>
        /// <param name="accessKey">
        /// Access key used for requests to the provider.
        /// </param>
        /// <param name="region">
        /// Region used for requests to the provider.
        /// </param>
        /// <param name="baseUrl">
        /// Base URL used for requests to the provider.
        /// </param>
        /// <param name="apiVersion">
        /// API version used for requests to the provider.
        /// </param>
        public ProviderCreate(
            string name,
            global::G.ProviderType providerType,
            string apiKey,
            string? accessKey,
            string? region,
            string? baseUrl,
            string? apiVersion)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProviderType = providerType;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.AccessKey = accessKey;
            this.Region = region;
            this.BaseUrl = baseUrl;
            this.ApiVersion = apiVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderCreate" /> class.
        /// </summary>
        public ProviderCreate()
        {
        }
    }
}
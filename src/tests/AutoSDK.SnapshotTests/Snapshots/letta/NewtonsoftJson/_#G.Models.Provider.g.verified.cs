//HintName: G.Models.Provider.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Provider
    {
        /// <summary>
        /// The id of the provider, lazily created by the database manager.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProviderTypeJsonConverter))]
        public global::G.ProviderType ProviderType { get; set; } = default!;

        /// <summary>
        /// The category of the provider (base or byok)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_category", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProviderCategoryJsonConverter))]
        public global::G.ProviderCategory ProviderCategory { get; set; } = default!;

        /// <summary>
        /// API key or secret key used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Base URL for the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Access key used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_key")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AccessKey { get; set; }

        /// <summary>
        /// Region used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// API version used for requests to the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// The last update timestamp of the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The last time models were synced for this provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_synced")]
        public global::System.DateTime? LastSynced { get; set; }

        /// <summary>
        /// Encrypted API key as Secret object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_enc")]
        public string? ApiKeyEnc { get; set; }

        /// <summary>
        /// Encrypted access key as Secret object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_key_enc")]
        public string? AccessKeyEnc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the provider
        /// </param>
        /// <param name="providerType">
        /// The type of the provider
        /// </param>
        /// <param name="providerCategory">
        /// The category of the provider (base or byok)
        /// </param>
        /// <param name="id">
        /// The id of the provider, lazily created by the database manager.
        /// </param>
        /// <param name="baseUrl">
        /// Base URL for the provider.
        /// </param>
        /// <param name="region">
        /// Region used for requests to the provider.
        /// </param>
        /// <param name="apiVersion">
        /// API version used for requests to the provider.
        /// </param>
        /// <param name="updatedAt">
        /// The last update timestamp of the provider.
        /// </param>
        /// <param name="lastSynced">
        /// The last time models were synced for this provider.
        /// </param>
        /// <param name="apiKeyEnc">
        /// Encrypted API key as Secret object
        /// </param>
        /// <param name="accessKeyEnc">
        /// Encrypted access key as Secret object
        /// </param>
        public Provider(
            string name,
            global::G.ProviderType providerType,
            global::G.ProviderCategory providerCategory,
            string? id,
            string? baseUrl,
            string? region,
            string? apiVersion,
            global::System.DateTime? updatedAt,
            global::System.DateTime? lastSynced,
            string? apiKeyEnc,
            string? accessKeyEnc)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProviderType = providerType;
            this.ProviderCategory = providerCategory;
            this.BaseUrl = baseUrl;
            this.Region = region;
            this.ApiVersion = apiVersion;
            this.UpdatedAt = updatedAt;
            this.LastSynced = lastSynced;
            this.ApiKeyEnc = apiKeyEnc;
            this.AccessKeyEnc = accessKeyEnc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class.
        /// </summary>
        public Provider()
        {
        }
    }
}
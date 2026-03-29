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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProviderType ProviderType { get; set; }

        /// <summary>
        /// API key or secret key used for requests to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Access key used for requests to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key")]
        public string? AccessKey { get; set; }

        /// <summary>
        /// Region used for requests to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Base URL used for requests to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// API version used for requests to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.ApiKeyCreateOrUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base class for API key create or update parameters.
    /// </summary>
    public sealed partial class ApiKeyCreateOrUpdateParams
    {
        /// <summary>
        /// Default Value: api_key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreateOrUpdateParams" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The API key
        /// </param>
        /// <param name="type">
        /// Default Value: api_key
        /// </param>
        public ApiKeyCreateOrUpdateParams(
            string apiKey,
            string? type)
        {
            this.Type = type;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreateOrUpdateParams" /> class.
        /// </summary>
        public ApiKeyCreateOrUpdateParams()
        {
        }
    }
}
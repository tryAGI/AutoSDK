//HintName: G.Models.DataSourceApiKeyParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication parameters for a API key data source.
    /// </summary>
    public sealed partial class DataSourceApiKeyParams
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
        /// Initializes a new instance of the <see cref="DataSourceApiKeyParams" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The API key
        /// </param>
        /// <param name="type">
        /// Default Value: api_key
        /// </param>
        public DataSourceApiKeyParams(
            string apiKey,
            string? type)
        {
            this.Type = type;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceApiKeyParams" /> class.
        /// </summary>
        public DataSourceApiKeyParams()
        {
        }
    }
}
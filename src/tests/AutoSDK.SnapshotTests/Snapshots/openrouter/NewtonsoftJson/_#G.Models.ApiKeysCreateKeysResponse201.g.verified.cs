//HintName: G.Models.ApiKeysCreateKeysResponse201.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeysCreateKeysResponse201
    {
        /// <summary>
        /// The created API key information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.KeysPostResponsesContentApplicationJsonSchemaData Data { get; set; } = default!;

        /// <summary>
        /// The actual API key string (only shown once)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysCreateKeysResponse201" /> class.
        /// </summary>
        /// <param name="data">
        /// The created API key information
        /// </param>
        /// <param name="key">
        /// The actual API key string (only shown once)
        /// </param>
        public ApiKeysCreateKeysResponse201(
            global::G.KeysPostResponsesContentApplicationJsonSchemaData data,
            string key)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysCreateKeysResponse201" /> class.
        /// </summary>
        public ApiKeysCreateKeysResponse201()
        {
        }
    }
}
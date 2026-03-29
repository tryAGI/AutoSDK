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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.KeysPostResponsesContentApplicationJsonSchemaData Data { get; set; }

        /// <summary>
        /// The actual API key string (only shown once)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
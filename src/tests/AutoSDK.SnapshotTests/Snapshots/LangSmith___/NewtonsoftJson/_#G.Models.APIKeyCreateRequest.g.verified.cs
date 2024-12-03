//HintName: G.Models.APIKeyCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API key POST schema.
    /// </summary>
    public sealed partial class APIKeyCreateRequest
    {
        /// <summary>
        /// Default Value: Default API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyCreateRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Default Value: Default API key
        /// </param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        public APIKeyCreateRequest(
            string? description,
            bool? readOnly)
        {
            this.Description = description;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyCreateRequest" /> class.
        /// </summary>
        public APIKeyCreateRequest()
        {
        }
    }
}
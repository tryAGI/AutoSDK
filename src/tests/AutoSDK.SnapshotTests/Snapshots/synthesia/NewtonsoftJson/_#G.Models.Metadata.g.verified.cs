//HintName: G.Models.Metadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event metadata (timestamps).
    /// </summary>
    public sealed partial class Metadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processedAt")]
        public global::System.DateTime? ProcessedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="processedAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public Metadata(
            global::System.DateTime createdAt,
            global::System.DateTime? processedAt)
        {
            this.CreatedAt = createdAt;
            this.ProcessedAt = processedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        public Metadata()
        {
        }
    }
}
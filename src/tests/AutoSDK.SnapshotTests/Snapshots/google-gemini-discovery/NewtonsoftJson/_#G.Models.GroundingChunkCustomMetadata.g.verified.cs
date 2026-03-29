//HintName: G.Models.GroundingChunkCustomMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User provided metadata about the GroundingFact.
    /// </summary>
    public sealed partial class GroundingChunkCustomMetadata
    {
        /// <summary>
        /// Optional. The string value of the metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stringValue")]
        public string? StringValue { get; set; }

        /// <summary>
        /// A list of string values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stringListValue")]
        public global::G.GroundingChunkStringList? StringListValue { get; set; }

        /// <summary>
        /// Optional. The numeric value of the metadata. The expected range for this value depends on the specific `key` used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numericValue")]
        public float? NumericValue { get; set; }

        /// <summary>
        /// The key of the metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingChunkCustomMetadata" /> class.
        /// </summary>
        /// <param name="stringValue">
        /// Optional. The string value of the metadata.
        /// </param>
        /// <param name="stringListValue">
        /// A list of string values.
        /// </param>
        /// <param name="numericValue">
        /// Optional. The numeric value of the metadata. The expected range for this value depends on the specific `key` used.
        /// </param>
        /// <param name="key">
        /// The key of the metadata.
        /// </param>
        public GroundingChunkCustomMetadata(
            string? stringValue,
            global::G.GroundingChunkStringList? stringListValue,
            float? numericValue,
            string? key)
        {
            this.StringValue = stringValue;
            this.StringListValue = stringListValue;
            this.NumericValue = numericValue;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingChunkCustomMetadata" /> class.
        /// </summary>
        public GroundingChunkCustomMetadata()
        {
        }
    }
}
//HintName: G.Models.ExtractJobMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extraction metadata.
    /// </summary>
    public sealed partial class ExtractJobMetadata
    {
        /// <summary>
        /// Per-field metadata (citations, confidence, reasoning)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field_metadata")]
        public global::G.ExtractedFieldMetadata? FieldMetadata { get; set; }

        /// <summary>
        /// Reference to the ParseJob ID used for parsing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parse_job_id")]
        public string? ParseJobId { get; set; }

        /// <summary>
        /// Parse tier used for parsing the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parse_tier")]
        public string? ParseTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobMetadata" /> class.
        /// </summary>
        /// <param name="fieldMetadata">
        /// Per-field metadata (citations, confidence, reasoning)
        /// </param>
        /// <param name="parseJobId">
        /// Reference to the ParseJob ID used for parsing
        /// </param>
        /// <param name="parseTier">
        /// Parse tier used for parsing the document
        /// </param>
        public ExtractJobMetadata(
            global::G.ExtractedFieldMetadata? fieldMetadata,
            string? parseJobId,
            string? parseTier)
        {
            this.FieldMetadata = fieldMetadata;
            this.ParseJobId = parseJobId;
            this.ParseTier = parseTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobMetadata" /> class.
        /// </summary>
        public ExtractJobMetadata()
        {
        }
    }
}
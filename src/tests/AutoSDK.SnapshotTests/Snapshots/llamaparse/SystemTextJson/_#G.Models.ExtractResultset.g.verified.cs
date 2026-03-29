//HintName: G.Models.ExtractResultset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for an extraction resultset.
    /// </summary>
    public sealed partial class ExtractResultset
    {
        /// <summary>
        /// The id of the extraction run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RunId { get; set; }

        /// <summary>
        /// The id of the extraction agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExtractionAgentId { get; set; }

        /// <summary>
        /// The data extracted from the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object> Data { get; set; }

        /// <summary>
        /// The metadata extracted from the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ExtractionMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResultset" /> class.
        /// </summary>
        /// <param name="runId">
        /// The id of the extraction run
        /// </param>
        /// <param name="extractionAgentId">
        /// The id of the extraction agent
        /// </param>
        /// <param name="data">
        /// The data extracted from the file
        /// </param>
        /// <param name="extractionMetadata">
        /// The metadata extracted from the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractResultset(
            global::System.Guid runId,
            global::System.Guid extractionAgentId,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object> data,
            object extractionMetadata)
        {
            this.RunId = runId;
            this.ExtractionAgentId = extractionAgentId;
            this.Data = data;
            this.ExtractionMetadata = extractionMetadata ?? throw new global::System.ArgumentNullException(nameof(extractionMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResultset" /> class.
        /// </summary>
        public ExtractResultset()
        {
        }
    }
}
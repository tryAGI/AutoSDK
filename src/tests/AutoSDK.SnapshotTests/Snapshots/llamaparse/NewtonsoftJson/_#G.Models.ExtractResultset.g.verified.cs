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
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RunId { get; set; } = default!;

        /// <summary>
        /// The id of the extraction agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExtractionAgentId { get; set; } = default!;

        /// <summary>
        /// The data extracted from the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object> Data { get; set; } = default!;

        /// <summary>
        /// The metadata extracted from the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object ExtractionMetadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
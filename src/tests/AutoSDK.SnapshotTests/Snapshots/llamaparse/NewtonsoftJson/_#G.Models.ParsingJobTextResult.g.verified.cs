//HintName: G.Models.ParsingJobTextResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parse job result as plain text.
    /// </summary>
    public sealed partial class ParsingJobTextResult
    {
        /// <summary>
        /// Full document content as plain text (no formatting)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Job metadata including credit usage and page counts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object JobMetadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobTextResult" /> class.
        /// </summary>
        /// <param name="text">
        /// Full document content as plain text (no formatting)
        /// </param>
        /// <param name="jobMetadata">
        /// Job metadata including credit usage and page counts
        /// </param>
        public ParsingJobTextResult(
            string text,
            object jobMetadata)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.JobMetadata = jobMetadata ?? throw new global::System.ArgumentNullException(nameof(jobMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobTextResult" /> class.
        /// </summary>
        public ParsingJobTextResult()
        {
        }
    }
}
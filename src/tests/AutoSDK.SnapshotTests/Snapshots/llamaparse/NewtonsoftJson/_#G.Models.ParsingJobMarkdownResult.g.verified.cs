//HintName: G.Models.ParsingJobMarkdownResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parse job result in markdown format.
    /// </summary>
    public sealed partial class ParsingJobMarkdownResult
    {
        /// <summary>
        /// Full document content rendered as markdown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("markdown", Required = global::Newtonsoft.Json.Required.Always)]
        public string Markdown { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ParsingJobMarkdownResult" /> class.
        /// </summary>
        /// <param name="markdown">
        /// Full document content rendered as markdown
        /// </param>
        /// <param name="jobMetadata">
        /// Job metadata including credit usage and page counts
        /// </param>
        public ParsingJobMarkdownResult(
            string markdown,
            object jobMetadata)
        {
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
            this.JobMetadata = jobMetadata ?? throw new global::System.ArgumentNullException(nameof(jobMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobMarkdownResult" /> class.
        /// </summary>
        public ParsingJobMarkdownResult()
        {
        }
    }
}
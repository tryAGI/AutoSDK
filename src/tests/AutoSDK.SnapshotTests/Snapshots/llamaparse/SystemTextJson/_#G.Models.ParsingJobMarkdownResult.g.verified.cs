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
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Job metadata including credit usage and page counts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object JobMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
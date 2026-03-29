//HintName: G.Models.ParsingJobJsonResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parse job result as structured JSON pages.
    /// </summary>
    public sealed partial class ParsingJobJsonResult
    {
        /// <summary>
        /// Array of per-page objects containing parsed content, images, and layout data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Pages { get; set; }

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
        /// Initializes a new instance of the <see cref="ParsingJobJsonResult" /> class.
        /// </summary>
        /// <param name="pages">
        /// Array of per-page objects containing parsed content, images, and layout data
        /// </param>
        /// <param name="jobMetadata">
        /// Job metadata including credit usage and page counts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParsingJobJsonResult(
            object pages,
            object jobMetadata)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.JobMetadata = jobMetadata ?? throw new global::System.ArgumentNullException(nameof(jobMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobJsonResult" /> class.
        /// </summary>
        public ParsingJobJsonResult()
        {
        }
    }
}
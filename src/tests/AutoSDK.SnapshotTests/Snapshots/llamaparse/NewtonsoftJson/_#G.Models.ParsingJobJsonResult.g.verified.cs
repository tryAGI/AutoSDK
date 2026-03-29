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
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public object Pages { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ParsingJobJsonResult" /> class.
        /// </summary>
        /// <param name="pages">
        /// Array of per-page objects containing parsed content, images, and layout data
        /// </param>
        /// <param name="jobMetadata">
        /// Job metadata including credit usage and page counts
        /// </param>
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
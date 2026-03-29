//HintName: G.Models.ParsingJobStructuredResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parse job result as structured output (custom schema).
    /// </summary>
    public sealed partial class ParsingJobStructuredResult
    {
        /// <summary>
        /// Extracted structured data conforming to the output_schema provided at job creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("structured", Required = global::Newtonsoft.Json.Required.Always)]
        public object Structured { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ParsingJobStructuredResult" /> class.
        /// </summary>
        /// <param name="structured">
        /// Extracted structured data conforming to the output_schema provided at job creation
        /// </param>
        /// <param name="jobMetadata">
        /// Job metadata including credit usage and page counts
        /// </param>
        public ParsingJobStructuredResult(
            object structured,
            object jobMetadata)
        {
            this.Structured = structured ?? throw new global::System.ArgumentNullException(nameof(structured));
            this.JobMetadata = jobMetadata ?? throw new global::System.ArgumentNullException(nameof(jobMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobStructuredResult" /> class.
        /// </summary>
        public ParsingJobStructuredResult()
        {
        }
    }
}
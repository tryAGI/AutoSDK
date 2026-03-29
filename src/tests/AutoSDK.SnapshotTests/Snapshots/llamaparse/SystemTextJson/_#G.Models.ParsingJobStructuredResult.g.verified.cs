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
        [global::System.Text.Json.Serialization.JsonPropertyName("structured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Structured { get; set; }

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
        /// Initializes a new instance of the <see cref="ParsingJobStructuredResult" /> class.
        /// </summary>
        /// <param name="structured">
        /// Extracted structured data conforming to the output_schema provided at job creation
        /// </param>
        /// <param name="jobMetadata">
        /// Job metadata including credit usage and page counts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

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
        /// Initializes a new instance of the <see cref="ParsingJobTextResult" /> class.
        /// </summary>
        /// <param name="text">
        /// Full document content as plain text (no formatting)
        /// </param>
        /// <param name="jobMetadata">
        /// Job metadata including credit usage and page counts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
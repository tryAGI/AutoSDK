//HintName: G.Models.TranscriptionConfigTranscriptFilteringConfigReplacement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionConfigTranscriptFilteringConfigReplacement
    {
        /// <summary>
        /// The text or pattern identified to be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// The corrected or formatted string to appear in the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigTranscriptFilteringConfigReplacement" /> class.
        /// </summary>
        /// <param name="from">
        /// The text or pattern identified to be replaced.
        /// </param>
        /// <param name="to">
        /// The corrected or formatted string to appear in the transcript.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionConfigTranscriptFilteringConfigReplacement(
            string from,
            string to)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigTranscriptFilteringConfigReplacement" /> class.
        /// </summary>
        public TranscriptionConfigTranscriptFilteringConfigReplacement()
        {
        }
    }
}
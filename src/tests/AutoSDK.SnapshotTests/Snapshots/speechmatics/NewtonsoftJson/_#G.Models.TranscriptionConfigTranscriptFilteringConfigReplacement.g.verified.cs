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
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public string From { get; set; } = default!;

        /// <summary>
        /// The corrected or formatted string to appear in the transcript.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public string To { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
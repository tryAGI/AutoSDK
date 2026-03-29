//HintName: G.Models.TranscriptionConfigTranscriptFilteringConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for applying filtering to the transcription.
    /// </summary>
    public sealed partial class TranscriptionConfigTranscriptFilteringConfig
    {
        /// <summary>
        /// If true, words identified as disfluencies (e.g., 'um', 'uh') will be removed from the transcript. If false (default), they are tagged in the transcript as 'disfluency'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_disfluencies")]
        public bool? RemoveDisfluencies { get; set; }

        /// <summary>
        /// An array of objects defining custom replacements. Each replacement contains a pair of strings: the text to find ("from:") and the text to replace it with ("to:").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replacements")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionConfigTranscriptFilteringConfigReplacement>? Replacements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigTranscriptFilteringConfig" /> class.
        /// </summary>
        /// <param name="removeDisfluencies">
        /// If true, words identified as disfluencies (e.g., 'um', 'uh') will be removed from the transcript. If false (default), they are tagged in the transcript as 'disfluency'.
        /// </param>
        /// <param name="replacements">
        /// An array of objects defining custom replacements. Each replacement contains a pair of strings: the text to find ("from:") and the text to replace it with ("to:").
        /// </param>
        public TranscriptionConfigTranscriptFilteringConfig(
            bool? removeDisfluencies,
            global::System.Collections.Generic.IList<global::G.TranscriptionConfigTranscriptFilteringConfigReplacement>? replacements)
        {
            this.RemoveDisfluencies = removeDisfluencies;
            this.Replacements = replacements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigTranscriptFilteringConfig" /> class.
        /// </summary>
        public TranscriptionConfigTranscriptFilteringConfig()
        {
        }
    }
}
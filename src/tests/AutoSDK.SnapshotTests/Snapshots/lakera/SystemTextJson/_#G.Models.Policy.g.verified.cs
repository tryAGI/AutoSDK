//HintName: G.Models.Policy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inline policy configuration that specifies which detectors to run and their thresholds.
    /// </summary>
    public sealed partial class Policy
    {
        /// <summary>
        /// Configuration for a threat detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injection")]
        public global::G.DetectorConfig? PromptInjection { get; set; }

        /// <summary>
        /// Configuration for a threat detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jailbreak")]
        public global::G.DetectorConfig? Jailbreak { get; set; }

        /// <summary>
        /// Configuration for the PII (Personally Identifiable Information) detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii")]
        public global::G.PiiDetectorConfig? Pii { get; set; }

        /// <summary>
        /// Configuration for a threat detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanity")]
        public global::G.DetectorConfig? Profanity { get; set; }

        /// <summary>
        /// Configuration for a threat detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("malicious_links")]
        public global::G.DetectorConfig? MaliciousLinks { get; set; }

        /// <summary>
        /// Configuration for a threat detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown_links")]
        public global::G.DetectorConfig? UnknownLinks { get; set; }

        /// <summary>
        /// Configuration for the relevant language detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevant_language")]
        public global::G.LanguageDetectorConfig? RelevantLanguage { get; set; }

        /// <summary>
        /// Configuration for the moderated content detector (toxicity, hate speech, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderated_content")]
        public global::G.ModeratedContentDetectorConfig? ModeratedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Policy" /> class.
        /// </summary>
        /// <param name="promptInjection">
        /// Configuration for a threat detector.
        /// </param>
        /// <param name="jailbreak">
        /// Configuration for a threat detector.
        /// </param>
        /// <param name="pii">
        /// Configuration for the PII (Personally Identifiable Information) detector.
        /// </param>
        /// <param name="profanity">
        /// Configuration for a threat detector.
        /// </param>
        /// <param name="maliciousLinks">
        /// Configuration for a threat detector.
        /// </param>
        /// <param name="unknownLinks">
        /// Configuration for a threat detector.
        /// </param>
        /// <param name="relevantLanguage">
        /// Configuration for the relevant language detector.
        /// </param>
        /// <param name="moderatedContent">
        /// Configuration for the moderated content detector (toxicity, hate speech, etc.).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Policy(
            global::G.DetectorConfig? promptInjection,
            global::G.DetectorConfig? jailbreak,
            global::G.PiiDetectorConfig? pii,
            global::G.DetectorConfig? profanity,
            global::G.DetectorConfig? maliciousLinks,
            global::G.DetectorConfig? unknownLinks,
            global::G.LanguageDetectorConfig? relevantLanguage,
            global::G.ModeratedContentDetectorConfig? moderatedContent)
        {
            this.PromptInjection = promptInjection;
            this.Jailbreak = jailbreak;
            this.Pii = pii;
            this.Profanity = profanity;
            this.MaliciousLinks = maliciousLinks;
            this.UnknownLinks = unknownLinks;
            this.RelevantLanguage = relevantLanguage;
            this.ModeratedContent = moderatedContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Policy" /> class.
        /// </summary>
        public Policy()
        {
        }
    }
}
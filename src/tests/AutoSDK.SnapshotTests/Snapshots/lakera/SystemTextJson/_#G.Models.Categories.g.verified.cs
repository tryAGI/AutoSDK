//HintName: G.Models.Categories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Per-category flagging results.
    /// </summary>
    public sealed partial class Categories
    {
        /// <summary>
        /// Whether prompt injection was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injection")]
        public bool? PromptInjection { get; set; }

        /// <summary>
        /// Whether a jailbreak attempt was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jailbreak")]
        public bool? Jailbreak { get; set; }

        /// <summary>
        /// Whether PII was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii")]
        public bool? Pii { get; set; }

        /// <summary>
        /// Whether profanity was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanity")]
        public bool? Profanity { get; set; }

        /// <summary>
        /// Whether malicious links were detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("malicious_links")]
        public bool? MaliciousLinks { get; set; }

        /// <summary>
        /// Whether unknown/unverified links were detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown_links")]
        public bool? UnknownLinks { get; set; }

        /// <summary>
        /// Whether the content is NOT in a relevant language (true = irrelevant language detected).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevant_language")]
        public bool? RelevantLanguage { get; set; }

        /// <summary>
        /// Whether moderated content (hate, harassment, etc.) was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderated_content")]
        public bool? ModeratedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Categories" /> class.
        /// </summary>
        /// <param name="promptInjection">
        /// Whether prompt injection was detected.
        /// </param>
        /// <param name="jailbreak">
        /// Whether a jailbreak attempt was detected.
        /// </param>
        /// <param name="pii">
        /// Whether PII was detected.
        /// </param>
        /// <param name="profanity">
        /// Whether profanity was detected.
        /// </param>
        /// <param name="maliciousLinks">
        /// Whether malicious links were detected.
        /// </param>
        /// <param name="unknownLinks">
        /// Whether unknown/unverified links were detected.
        /// </param>
        /// <param name="relevantLanguage">
        /// Whether the content is NOT in a relevant language (true = irrelevant language detected).
        /// </param>
        /// <param name="moderatedContent">
        /// Whether moderated content (hate, harassment, etc.) was detected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Categories(
            bool? promptInjection,
            bool? jailbreak,
            bool? pii,
            bool? profanity,
            bool? maliciousLinks,
            bool? unknownLinks,
            bool? relevantLanguage,
            bool? moderatedContent)
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
        /// Initializes a new instance of the <see cref="Categories" /> class.
        /// </summary>
        public Categories()
        {
        }
    }
}
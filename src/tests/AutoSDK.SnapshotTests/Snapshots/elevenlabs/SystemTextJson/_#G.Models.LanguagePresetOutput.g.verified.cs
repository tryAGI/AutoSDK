//HintName: G.Models.LanguagePresetOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguagePresetOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationConfigClientOverrideOutput Overrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_translation")]
        public global::G.LanguagePresetTranslation? FirstMessageTranslation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePresetOutput" /> class.
        /// </summary>
        /// <param name="overrides"></param>
        /// <param name="firstMessageTranslation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguagePresetOutput(
            global::G.ConversationConfigClientOverrideOutput overrides,
            global::G.LanguagePresetTranslation? firstMessageTranslation)
        {
            this.Overrides = overrides ?? throw new global::System.ArgumentNullException(nameof(overrides));
            this.FirstMessageTranslation = firstMessageTranslation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePresetOutput" /> class.
        /// </summary>
        public LanguagePresetOutput()
        {
        }
    }
}
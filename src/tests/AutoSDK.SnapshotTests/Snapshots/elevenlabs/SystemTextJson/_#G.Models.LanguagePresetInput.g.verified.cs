//HintName: G.Models.LanguagePresetInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguagePresetInput
    {
        /// <summary>
        /// The overrides for the language preset<br/>
        /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}
        /// </summary>
        /// <example>{"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationConfigClientOverrideInput Overrides { get; set; }

        /// <summary>
        /// The translation of the first message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message_translation")]
        public global::G.LanguagePresetTranslation? FirstMessageTranslation { get; set; }

        /// <summary>
        /// The translation of the soft timeout message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_timeout_translation")]
        public global::G.LanguagePresetTranslation? SoftTimeoutTranslation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePresetInput" /> class.
        /// </summary>
        /// <param name="overrides">
        /// The overrides for the language preset<br/>
        /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}
        /// </param>
        /// <param name="firstMessageTranslation">
        /// The translation of the first message
        /// </param>
        /// <param name="softTimeoutTranslation">
        /// The translation of the soft timeout message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguagePresetInput(
            global::G.ConversationConfigClientOverrideInput overrides,
            global::G.LanguagePresetTranslation? firstMessageTranslation,
            global::G.LanguagePresetTranslation? softTimeoutTranslation)
        {
            this.Overrides = overrides ?? throw new global::System.ArgumentNullException(nameof(overrides));
            this.FirstMessageTranslation = firstMessageTranslation;
            this.SoftTimeoutTranslation = softTimeoutTranslation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePresetInput" /> class.
        /// </summary>
        public LanguagePresetInput()
        {
        }
    }
}
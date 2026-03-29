//HintName: G.Models.VoicemailActionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicemailActionPrompt
    {
        /// <summary>
        /// Example: prompt
        /// </summary>
        /// <example>prompt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoicemailActionPromptTypeJsonConverter))]
        public global::G.VoicemailActionPromptType Type { get; set; }

        /// <summary>
        /// The prompt used to generate the text to be spoken when the call is detected to be in voicemail.<br/>
        /// Example: Summarize the call in 2 sentences.
        /// </summary>
        /// <example>Summarize the call in 2 sentences.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionPrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// The prompt used to generate the text to be spoken when the call is detected to be in voicemail.<br/>
        /// Example: Summarize the call in 2 sentences.
        /// </param>
        /// <param name="type">
        /// Example: prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicemailActionPrompt(
            string text,
            global::G.VoicemailActionPromptType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionPrompt" /> class.
        /// </summary>
        public VoicemailActionPrompt()
        {
        }
    }
}
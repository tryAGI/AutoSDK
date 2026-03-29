//HintName: G.Models.VoicemailActionStaticText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicemailActionStaticText
    {
        /// <summary>
        /// Example: static_text
        /// </summary>
        /// <example>static_text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoicemailActionStaticTextTypeJsonConverter))]
        public global::G.VoicemailActionStaticTextType Type { get; set; }

        /// <summary>
        /// The text to be spoken when the call is detected to be in voicemail.<br/>
        /// Example: Please give us a callback tomorrow at 10am.
        /// </summary>
        /// <example>Please give us a callback tomorrow at 10am.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionStaticText" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to be spoken when the call is detected to be in voicemail.<br/>
        /// Example: Please give us a callback tomorrow at 10am.
        /// </param>
        /// <param name="type">
        /// Example: static_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicemailActionStaticText(
            string text,
            global::G.VoicemailActionStaticTextType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionStaticText" /> class.
        /// </summary>
        public VoicemailActionStaticText()
        {
        }
    }
}
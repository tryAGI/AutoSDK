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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.VoicemailActionStaticTextType Type { get; set; }

        /// <summary>
        /// The text to be spoken when the call is detected to be in voicemail.<br/>
        /// Example: Please give us a callback tomorrow at 10am.
        /// </summary>
        /// <example>Please give us a callback tomorrow at 10am.</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
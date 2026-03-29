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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.VoicemailActionPromptType Type { get; set; }

        /// <summary>
        /// The prompt used to generate the text to be spoken when the call is detected to be in voicemail.<br/>
        /// Example: Summarize the call in 2 sentences.
        /// </summary>
        /// <example>Summarize the call in 2 sentences.</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
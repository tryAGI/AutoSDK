//HintName: G.Models.DialogueInputResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DialogueInputResponseModel
    {
        /// <summary>
        /// The text of the dialogue input line.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The ID of the voice used for this dialogue input line.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// The name of the voice used for this dialogue input line.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogueInputResponseModel" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the dialogue input line.
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice used for this dialogue input line.
        /// </param>
        /// <param name="voiceName">
        /// The name of the voice used for this dialogue input line.
        /// </param>
        public DialogueInputResponseModel(
            string text,
            string voiceId,
            string voiceName)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogueInputResponseModel" /> class.
        /// </summary>
        public DialogueInputResponseModel()
        {
        }
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The ID of the voice used for this dialogue input line.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// The name of the voice used for this dialogue input line.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
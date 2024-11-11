//HintName: G.Models.V2VideoGenerateRequestVideoInputVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequestVideoInputVoice
    {
        /// <summary>
        /// Example: Welcome to the new era of video creation with HeyGen! Simply type your script to get started!
        /// </summary>
        /// <example>Welcome to the new era of video creation with HeyGen! Simply type your script to get started!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: 2f72ee82b83d4b00af16c4771d611752
        /// </summary>
        /// <example>2f72ee82b83d4b00af16c4771d611752</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInputVoice" /> class.
        /// </summary>
        /// <param name="inputText">
        /// Example: Welcome to the new era of video creation with HeyGen! Simply type your script to get started!
        /// </param>
        /// <param name="type">
        /// Example: text
        /// </param>
        /// <param name="voiceId">
        /// Example: 2f72ee82b83d4b00af16c4771d611752
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public V2VideoGenerateRequestVideoInputVoice(
            string? inputText,
            string? type,
            string? voiceId)
        {
            this.InputText = inputText;
            this.Type = type;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInputVoice" /> class.
        /// </summary>
        public V2VideoGenerateRequestVideoInputVoice()
        {
        }
    }
}
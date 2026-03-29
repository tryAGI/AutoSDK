//HintName: G.Models.ChatContentAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio input content part. Supported audio formats vary by provider.
    /// </summary>
    public sealed partial class ChatContentAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatContentAudioTypeJsonConverter))]
        public global::G.ChatContentAudioType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatContentAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentAudio" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentAudio(
            global::G.ChatContentAudioInputAudio inputAudio,
            global::G.ChatContentAudioType type)
        {
            this.Type = type;
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentAudio" /> class.
        /// </summary>
        public ChatContentAudio()
        {
        }
    }
}
//HintName: G.Models.CreateChatCompletionRequestAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for audio output. Required when audio output is requested with<br/>
    /// `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
    /// </summary>
    public sealed partial class CreateChatCompletionRequestAudio
    {
        /// <summary>
        /// The voice the model uses to respond. Supported voices are `ash`, `ballad`, `coral`, `sage`, and `verse` (also supported but not recommended are `alloy`, `echo`, and `shimmer`; these voices are less expressive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionRequestAudioVoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateChatCompletionRequestAudioVoice Voice { get; set; }

        /// <summary>
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionRequestAudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateChatCompletionRequestAudioFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestAudio" /> class.
        /// </summary>
        /// <param name="voice">
        /// The voice the model uses to respond. Supported voices are `ash`, `ballad`, `coral`, `sage`, and `verse` (also supported but not recommended are `alloy`, `echo`, and `shimmer`; these voices are less expressive).
        /// </param>
        /// <param name="format">
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateChatCompletionRequestAudio(
            global::G.CreateChatCompletionRequestAudioVoice voice,
            global::G.CreateChatCompletionRequestAudioFormat format)
        {
            this.Voice = voice;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestAudio" /> class.
        /// </summary>
        public CreateChatCompletionRequestAudio()
        {
        }
    }
}
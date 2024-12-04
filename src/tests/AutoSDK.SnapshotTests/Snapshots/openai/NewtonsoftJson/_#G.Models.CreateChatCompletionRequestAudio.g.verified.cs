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
        [global::Newtonsoft.Json.JsonProperty("voice", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateChatCompletionRequestAudioVoice Voice { get; set; } = default!;

        /// <summary>
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateChatCompletionRequestAudioFormat Format { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
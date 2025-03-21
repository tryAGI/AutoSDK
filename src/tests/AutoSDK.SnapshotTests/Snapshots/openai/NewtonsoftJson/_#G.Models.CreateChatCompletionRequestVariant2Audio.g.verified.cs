//HintName: G.Models.CreateChatCompletionRequestVariant2Audio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for audio output. Required when audio output is requested with<br/>
    /// `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
    /// </summary>
    public sealed partial class CreateChatCompletionRequestVariant2Audio
    {
        /// <summary>
        /// The voice the model uses to respond. Supported voices are <br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, and `shimmer`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateChatCompletionRequestVariant2AudioVoice Voice { get; set; } = default!;

        /// <summary>
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateChatCompletionRequestVariant2AudioFormat Format { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2Audio" /> class.
        /// </summary>
        /// <param name="voice">
        /// The voice the model uses to respond. Supported voices are <br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, and `shimmer`.
        /// </param>
        /// <param name="format">
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </param>
        public CreateChatCompletionRequestVariant2Audio(
            global::G.CreateChatCompletionRequestVariant2AudioVoice voice,
            global::G.CreateChatCompletionRequestVariant2AudioFormat format)
        {
            this.Voice = voice;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2Audio" /> class.
        /// </summary>
        public CreateChatCompletionRequestVariant2Audio()
        {
        }
    }
}
//HintName: G.Models.ChatCompletionRequestMessageContentPartAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn about [audio inputs](/docs/guides/audio).
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionRequestMessageContentPartAudioInputAudio InputAudio { get; set; } = default!;

        /// <summary>
        /// The type of the content part. Always `input_audio`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionRequestMessageContentPartAudioType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudio" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type">
        /// The type of the content part. Always `input_audio`.
        /// </param>
        public ChatCompletionRequestMessageContentPartAudio(
            global::G.ChatCompletionRequestMessageContentPartAudioInputAudio inputAudio,
            global::G.ChatCompletionRequestMessageContentPartAudioType type)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudio" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartAudio()
        {
        }
    }
}
//HintName: G.Models.ChatCompletionRequestMessageContentPartAudioInputAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartAudioInputAudio
    {
        /// <summary>
        /// Base64 encoded audio data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// The format of the encoded audio data. Currently supports "wav" and "mp3".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionRequestMessageContentPartAudioInputAudioFormat Format { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudioInputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64 encoded audio data.
        /// </param>
        /// <param name="format">
        /// The format of the encoded audio data. Currently supports "wav" and "mp3".
        /// </param>
        public ChatCompletionRequestMessageContentPartAudioInputAudio(
            string data,
            global::G.ChatCompletionRequestMessageContentPartAudioInputAudioFormat format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartAudioInputAudio" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartAudioInputAudio()
        {
        }
    }
}
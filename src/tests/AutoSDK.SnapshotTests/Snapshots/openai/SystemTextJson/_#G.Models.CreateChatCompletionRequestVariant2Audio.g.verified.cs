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
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionRequestVariant2AudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateChatCompletionRequestVariant2AudioFormat Format { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Supported voices are <br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, and `shimmer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionRequestVariant2AudioVoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateChatCompletionRequestVariant2AudioVoice Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2Audio" /> class.
        /// </summary>
        /// <param name="format">
        /// Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,<br/>
        /// `opus`, or `pcm16`.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Supported voices are <br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, and `shimmer`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestVariant2Audio(
            global::G.CreateChatCompletionRequestVariant2AudioFormat format,
            global::G.CreateChatCompletionRequestVariant2AudioVoice voice)
        {
            this.Format = format;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2Audio" /> class.
        /// </summary>
        public CreateChatCompletionRequestVariant2Audio()
        {
        }
    }
}
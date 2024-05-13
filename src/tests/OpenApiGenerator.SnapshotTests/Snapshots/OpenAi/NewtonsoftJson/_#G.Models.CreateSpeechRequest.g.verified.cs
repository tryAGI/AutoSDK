//HintName: G.Models.CreateSpeechRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechRequest
    {
        /// <summary>
        /// One of the available [TTS models](/docs/models/tts): `tts-1` or `tts-1-hd`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public object Model { get; set; } = default!;

        /// <summary>
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// The voice to use when generating the audio. Supported voices are `alloy`, `echo`, `fable`, `onyx`, `nova`, and `shimmer`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech/voice-options).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice", Required = global::Newtonsoft.Json.Required.Always)]
        public CreateSpeechRequestVoice Voice { get; set; } = default!;

        /// <summary>
        /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.
        /// <br/>Default Value: mp3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public CreateSpeechRequestResponseFormat? ResponseFormat { get; set; } = CreateSpeechRequestResponseFormat.Mp3;

        /// <summary>
        /// The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default.
        /// <br/>Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double Speed { get; set; } = 1;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
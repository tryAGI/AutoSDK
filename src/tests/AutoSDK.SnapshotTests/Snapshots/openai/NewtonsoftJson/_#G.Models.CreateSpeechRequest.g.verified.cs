//HintName: G.Models.CreateSpeechRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechRequest
    {
        /// <summary>
        /// One of the available [TTS models](/docs/models#tts): `tts-1`, `tts-1-hd` or `gpt-4o-mini-tts`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::G.CreateSpeechRequestModel?> Model { get; set; } = default!;

        /// <summary>
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// Control the voice of your generated audio with additional instructions. Does not work with `tts-1` or `tts-1-hd`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Example: ash
        /// </summary>
        /// <example>ash</example>
        [global::Newtonsoft.Json.JsonProperty("voice", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VoiceIdsShared Voice { get; set; } = default!;

        /// <summary>
        /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.CreateSpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default. Does not work with `gpt-4o-mini-tts`.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// One of the available [TTS models](/docs/models#tts): `tts-1`, `tts-1-hd` or `gpt-4o-mini-tts`.
        /// </param>
        /// <param name="input">
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </param>
        /// <param name="instructions">
        /// Control the voice of your generated audio with additional instructions. Does not work with `tts-1` or `tts-1-hd`.
        /// </param>
        /// <param name="voice">
        /// Example: ash
        /// </param>
        /// <param name="responseFormat">
        /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="speed">
        /// The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default. Does not work with `gpt-4o-mini-tts`.<br/>
        /// Default Value: 1
        /// </param>
        public CreateSpeechRequest(
            global::G.AnyOf<string, global::G.CreateSpeechRequestModel?> model,
            string input,
            global::G.VoiceIdsShared voice,
            string? instructions,
            global::G.CreateSpeechRequestResponseFormat? responseFormat,
            double? speed)
        {
            this.Model = model;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice;
            this.Instructions = instructions;
            this.ResponseFormat = responseFormat;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        public CreateSpeechRequest()
        {
        }
    }
}
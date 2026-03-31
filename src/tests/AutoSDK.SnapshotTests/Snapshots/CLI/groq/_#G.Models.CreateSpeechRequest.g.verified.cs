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
        /// One of the [available TTS models](/docs/text-to-speech).<br/>
        /// Example: playai-tts
        /// </summary>
        /// <example>playai-tts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateSpeechRequestModel?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::G.CreateSpeechRequestModel?> Model { get; set; }

        /// <summary>
        /// The text to generate audio for.<br/>
        /// Example: The quick brown fox jumped over the lazy dog
        /// </summary>
        /// <example>The quick brown fox jumped over the lazy dog</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The voice to use when generating the audio. List of voices can be found [here](/docs/text-to-speech).<br/>
        /// Example: Fritz-PlayAI
        /// </summary>
        /// <example>Fritz-PlayAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// The format of the generated audio. Supported formats are `flac, mp3, mulaw, ogg, wav`.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter))]
        public global::G.CreateSpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The sample rate for generated audio<br/>
        /// Default Value: 48000<br/>
        /// Example: 48000
        /// </summary>
        /// <example>48000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// The speed of the generated audio.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// One of the [available TTS models](/docs/text-to-speech).<br/>
        /// Example: playai-tts
        /// </param>
        /// <param name="input">
        /// The text to generate audio for.<br/>
        /// Example: The quick brown fox jumped over the lazy dog
        /// </param>
        /// <param name="voice">
        /// The voice to use when generating the audio. List of voices can be found [here](/docs/text-to-speech).<br/>
        /// Example: Fritz-PlayAI
        /// </param>
        /// <param name="responseFormat">
        /// The format of the generated audio. Supported formats are `flac, mp3, mulaw, ogg, wav`.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate for generated audio<br/>
        /// Default Value: 48000<br/>
        /// Example: 48000
        /// </param>
        /// <param name="speed">
        /// The speed of the generated audio.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechRequest(
            global::G.AnyOf<string, global::G.CreateSpeechRequestModel?> model,
            string input,
            string voice,
            global::G.CreateSpeechRequestResponseFormat? responseFormat,
            int? sampleRate,
            double? speed)
        {
            this.Model = model;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.ResponseFormat = responseFormat;
            this.SampleRate = sampleRate;
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
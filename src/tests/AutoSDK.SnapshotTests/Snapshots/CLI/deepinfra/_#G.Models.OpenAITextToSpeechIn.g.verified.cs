//HintName: G.Models.OpenAITextToSpeechIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAITextToSpeechIn
    {
        /// <summary>
        /// model name<br/>
        /// Example: deepinfra/tts
        /// </summary>
        /// <example>deepinfra/tts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Text to convert to speech<br/>
        /// Example: I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </summary>
        /// <example>
        /// I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Preset voices to use for the speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Select the desired format for the speech output. Supported formats include mp3, opus, flac, wav, and pcm.<br/>
        /// Default Value: wav<br/>
        /// Example: mp3
        /// </summary>
        /// <example>mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TtsResponseFormatJsonConverter))]
        public global::G.TtsResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// speed of the speech<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Extra body parameters for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_body")]
        public object? ExtraBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITextToSpeechIn" /> class.
        /// </summary>
        /// <param name="model">
        /// model name<br/>
        /// Example: deepinfra/tts
        /// </param>
        /// <param name="input">
        /// Text to convert to speech<br/>
        /// Example: I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </param>
        /// <param name="voice">
        /// Preset voices to use for the speech.
        /// </param>
        /// <param name="responseFormat">
        /// Select the desired format for the speech output. Supported formats include mp3, opus, flac, wav, and pcm.<br/>
        /// Default Value: wav<br/>
        /// Example: mp3
        /// </param>
        /// <param name="speed">
        /// speed of the speech<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="extraBody">
        /// Extra body parameters for the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAITextToSpeechIn(
            string model,
            string input,
            string? voice,
            global::G.TtsResponseFormat? responseFormat,
            double? speed,
            object? extraBody)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice;
            this.ResponseFormat = responseFormat;
            this.Speed = speed;
            this.ExtraBody = extraBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITextToSpeechIn" /> class.
        /// </summary>
        public OpenAITextToSpeechIn()
        {
        }
    }
}
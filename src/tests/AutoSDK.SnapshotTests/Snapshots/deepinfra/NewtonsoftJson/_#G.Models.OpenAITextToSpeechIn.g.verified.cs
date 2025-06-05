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
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// Preset voices to use for the speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Select the desired format for the speech output. Supported formats include mp3, opus, flac, wav, and pcm.<br/>
        /// Default Value: wav<br/>
        /// Example: mp3
        /// </summary>
        /// <example>mp3</example>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.TtsResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// speed of the speech<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Extra body parameters for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_body")]
        public object? ExtraBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
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
        /// model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Text to convert to speech
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// Preset voices to use for the speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// response format for the speech<br/>
        /// Default Value: wav
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.TtsResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// speed of the speech<br/>
        /// Default Value: 1F
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
        /// model name
        /// </param>
        /// <param name="input">
        /// Text to convert to speech
        /// </param>
        /// <param name="voice">
        /// Preset voices to use for the speech.
        /// </param>
        /// <param name="responseFormat">
        /// response format for the speech<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="speed">
        /// speed of the speech<br/>
        /// Default Value: 1F
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
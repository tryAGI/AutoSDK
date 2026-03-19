//HintName: G.Models.ResponseConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a response.
    /// </summary>
    public sealed partial class ResponseConfig
    {
        /// <summary>
        /// The modalities for the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<global::G.ResponseConfigModalitie>? Modalities { get; set; }

        /// <summary>
        /// Instructions for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The voice the model uses to respond.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.ResponseConfigVoice? Voice { get; set; }

        /// <summary>
        /// The format of input/output audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_audio_format")]
        public global::G.AudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.ResponseConfigToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfig" /> class.
        /// </summary>
        /// <param name="modalities">
        /// The modalities for the response.
        /// </param>
        /// <param name="instructions">
        /// Instructions for the model.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of input/output audio.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of output tokens.
        /// </param>
        public ResponseConfig(
            global::System.Collections.Generic.IList<global::G.ResponseConfigModalitie>? modalities,
            string? instructions,
            global::G.ResponseConfigVoice? voice,
            global::G.AudioFormat? outputAudioFormat,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.ResponseConfigToolChoice? toolChoice,
            double? temperature,
            int? maxOutputTokens)
        {
            this.Modalities = modalities;
            this.Instructions = instructions;
            this.Voice = voice;
            this.OutputAudioFormat = outputAudioFormat;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxOutputTokens = maxOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfig" /> class.
        /// </summary>
        public ResponseConfig()
        {
        }
    }
}
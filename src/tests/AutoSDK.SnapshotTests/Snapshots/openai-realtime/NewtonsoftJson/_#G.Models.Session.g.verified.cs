//HintName: G.Models.Session.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Realtime session configuration.
    /// </summary>
    public sealed partial class Session
    {
        /// <summary>
        /// The unique ID of the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SessionObjectJsonConverter))]
        public global::G.SessionObject? Object { get; set; }

        /// <summary>
        /// The default model used for this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<string>? Modalities { get; set; }

        /// <summary>
        /// The default system instructions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The voice the model uses to respond.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SessionVoiceJsonConverter))]
        public global::G.SessionVoice? Voice { get; set; }

        /// <summary>
        /// The format of input/output audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AudioFormatJsonConverter))]
        public global::G.AudioFormat? InputAudioFormat { get; set; }

        /// <summary>
        /// The format of input/output audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_audio_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AudioFormatJsonConverter))]
        public global::G.AudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_transcription")]
        public global::G.SessionInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// Configuration for turn detection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_detection")]
        public global::G.SessionTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SessionToolChoiceJsonConverter))]
        public global::G.SessionToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the session.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
        /// <param name="model">
        /// The default model used for this session.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond.
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input/output audio.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of input/output audio.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of output tokens for a single assistant response.
        /// </param>
        public Session(
            string? id,
            global::G.SessionObject? @object,
            string? model,
            global::System.Collections.Generic.IList<string>? modalities,
            string? instructions,
            global::G.SessionVoice? voice,
            global::G.AudioFormat? inputAudioFormat,
            global::G.AudioFormat? outputAudioFormat,
            global::G.SessionInputAudioTranscription? inputAudioTranscription,
            global::G.SessionTurnDetection? turnDetection,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.SessionToolChoice? toolChoice,
            double? temperature,
            int? maxOutputTokens)
        {
            this.Id = id;
            this.Object = @object;
            this.Model = model;
            this.Modalities = modalities;
            this.Instructions = instructions;
            this.Voice = voice;
            this.InputAudioFormat = inputAudioFormat;
            this.OutputAudioFormat = outputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.TurnDetection = turnDetection;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxOutputTokens = maxOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        public Session()
        {
        }
    }
}
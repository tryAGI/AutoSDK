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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionObjectJsonConverter))]
        public global::G.SessionObject? Object { get; set; }

        /// <summary>
        /// The default model used for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<string>? Modalities { get; set; }

        /// <summary>
        /// The default system instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The voice the model uses to respond.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionVoiceJsonConverter))]
        public global::G.SessionVoice? Voice { get; set; }

        /// <summary>
        /// The format of input/output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioFormatJsonConverter))]
        public global::G.AudioFormat? InputAudioFormat { get; set; }

        /// <summary>
        /// The format of input/output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioFormatJsonConverter))]
        public global::G.AudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_transcription")]
        public global::G.SessionInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// Configuration for turn detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::G.SessionTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionToolChoiceJsonConverter))]
        public global::G.SessionToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
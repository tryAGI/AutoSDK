//HintName: G.Models.VoiceDesignRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceDesignRequestModel
    {
        /// <summary>
        /// Description to use for the created voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceDescription { get; set; }

        /// <summary>
        /// Model to use for the voice generation. Possible values: eleven_multilingual_ttv_v2, eleven_ttv_v3.<br/>
        /// Default Value: eleven_multilingual_ttv_v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter))]
        public global::G.VoiceDesignRequestModelModelId? ModelId { get; set; }

        /// <summary>
        /// Text to generate, text length has to be between 100 and 1000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Whether to automatically generate a text suitable for the voice description.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_generate_text")]
        public bool? AutoGenerateText { get; set; }

        /// <summary>
        /// Controls the volume level of the generated voice. -1 is quietest, 1 is loudest, 0 corresponds to roughly -24 LUFS.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness")]
        public double? Loudness { get; set; }

        /// <summary>
        /// Random number that controls the voice generation. Same seed with same inputs produces same voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Controls how closely the AI follows the prompt. Lower numbers give the AI more freedom to be creative, while higher numbers force it to stick more to the prompt. High numbers can cause voice to sound artificial or robotic. We recommend to use longer, more detailed prompts at lower Guidance Scale.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Determines whether the Text to Voice previews should be included in the response. If true, only the generated IDs will be returned which can then be streamed via the /v1/text-to-voice/:generated_voice_id/stream endpoint.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_previews")]
        public bool? StreamPreviews { get; set; }

        /// <summary>
        /// Whether to enhance the voice description using AI to add more detail and improve voice generation quality. When enabled, the system will automatically expand simple prompts into more detailed voice descriptions. Defaults to False<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_enhance")]
        public bool? ShouldEnhance { get; set; }

        /// <summary>
        /// The remixing session id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remixing_session_id")]
        public string? RemixingSessionId { get; set; }

        /// <summary>
        /// The id of the remixing session iteration where these generations should be attached to. If not provided, a new iteration will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remixing_session_iteration_id")]
        public string? RemixingSessionIterationId { get; set; }

        /// <summary>
        /// Higher quality results in better voice output but less variety.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public double? Quality { get; set; }

        /// <summary>
        /// Reference audio to use for the voice generation. The audio should be base64 encoded. Only supported when using the  eleven_ttv_v3 model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_audio_base64")]
        public string? ReferenceAudioBase64 { get; set; }

        /// <summary>
        /// Controls the balance of prompt versus reference audio when generating voice samples. 0 means almost no prompt influence, 1 means almost no reference audio influence. Only supported when using the eleven_ttv_v3 model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_strength")]
        public double? PromptStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignRequestModel" /> class.
        /// </summary>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.
        /// </param>
        /// <param name="modelId">
        /// Model to use for the voice generation. Possible values: eleven_multilingual_ttv_v2, eleven_ttv_v3.<br/>
        /// Default Value: eleven_multilingual_ttv_v2
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.
        /// </param>
        /// <param name="autoGenerateText">
        /// Whether to automatically generate a text suitable for the voice description.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="loudness">
        /// Controls the volume level of the generated voice. -1 is quietest, 1 is loudest, 0 corresponds to roughly -24 LUFS.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="seed">
        /// Random number that controls the voice generation. Same seed with same inputs produces same voice.
        /// </param>
        /// <param name="guidanceScale">
        /// Controls how closely the AI follows the prompt. Lower numbers give the AI more freedom to be creative, while higher numbers force it to stick more to the prompt. High numbers can cause voice to sound artificial or robotic. We recommend to use longer, more detailed prompts at lower Guidance Scale.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="streamPreviews">
        /// Determines whether the Text to Voice previews should be included in the response. If true, only the generated IDs will be returned which can then be streamed via the /v1/text-to-voice/:generated_voice_id/stream endpoint.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="shouldEnhance">
        /// Whether to enhance the voice description using AI to add more detail and improve voice generation quality. When enabled, the system will automatically expand simple prompts into more detailed voice descriptions. Defaults to False<br/>
        /// Default Value: false
        /// </param>
        /// <param name="remixingSessionId">
        /// The remixing session id.
        /// </param>
        /// <param name="remixingSessionIterationId">
        /// The id of the remixing session iteration where these generations should be attached to. If not provided, a new iteration will be created.
        /// </param>
        /// <param name="quality">
        /// Higher quality results in better voice output but less variety.
        /// </param>
        /// <param name="referenceAudioBase64">
        /// Reference audio to use for the voice generation. The audio should be base64 encoded. Only supported when using the  eleven_ttv_v3 model.
        /// </param>
        /// <param name="promptStrength">
        /// Controls the balance of prompt versus reference audio when generating voice samples. 0 means almost no prompt influence, 1 means almost no reference audio influence. Only supported when using the eleven_ttv_v3 model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignRequestModel(
            string voiceDescription,
            global::G.VoiceDesignRequestModelModelId? modelId,
            string? text,
            bool? autoGenerateText,
            double? loudness,
            int? seed,
            double? guidanceScale,
            bool? streamPreviews,
            bool? shouldEnhance,
            string? remixingSessionId,
            string? remixingSessionIterationId,
            double? quality,
            string? referenceAudioBase64,
            double? promptStrength)
        {
            this.VoiceDescription = voiceDescription ?? throw new global::System.ArgumentNullException(nameof(voiceDescription));
            this.ModelId = modelId;
            this.Text = text;
            this.AutoGenerateText = autoGenerateText;
            this.Loudness = loudness;
            this.Seed = seed;
            this.GuidanceScale = guidanceScale;
            this.StreamPreviews = streamPreviews;
            this.ShouldEnhance = shouldEnhance;
            this.RemixingSessionId = remixingSessionId;
            this.RemixingSessionIterationId = remixingSessionIterationId;
            this.Quality = quality;
            this.ReferenceAudioBase64 = referenceAudioBase64;
            this.PromptStrength = promptStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignRequestModel" /> class.
        /// </summary>
        public VoiceDesignRequestModel()
        {
        }
    }
}
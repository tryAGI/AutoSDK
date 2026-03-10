//HintName: G.Models.VoiceRemixRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceRemixRequestModel
    {
        /// <summary>
        /// Description of the changes to make to the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceDescription { get; set; }

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
        /// Default Value: 2
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
        /// Initializes a new instance of the <see cref="VoiceRemixRequestModel" /> class.
        /// </summary>
        /// <param name="voiceDescription">
        /// Description of the changes to make to the voice.
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
        /// Default Value: 2
        /// </param>
        /// <param name="streamPreviews">
        /// Determines whether the Text to Voice previews should be included in the response. If true, only the generated IDs will be returned which can then be streamed via the /v1/text-to-voice/:generated_voice_id/stream endpoint.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="remixingSessionId">
        /// The remixing session id.
        /// </param>
        /// <param name="remixingSessionIterationId">
        /// The id of the remixing session iteration where these generations should be attached to. If not provided, a new iteration will be created.
        /// </param>
        /// <param name="promptStrength">
        /// Controls the balance of prompt versus reference audio when generating voice samples. 0 means almost no prompt influence, 1 means almost no reference audio influence. Only supported when using the eleven_ttv_v3 model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceRemixRequestModel(
            string voiceDescription,
            string? text,
            bool? autoGenerateText,
            double? loudness,
            int? seed,
            double? guidanceScale,
            bool? streamPreviews,
            string? remixingSessionId,
            string? remixingSessionIterationId,
            double? promptStrength)
        {
            this.VoiceDescription = voiceDescription ?? throw new global::System.ArgumentNullException(nameof(voiceDescription));
            this.Text = text;
            this.AutoGenerateText = autoGenerateText;
            this.Loudness = loudness;
            this.Seed = seed;
            this.GuidanceScale = guidanceScale;
            this.StreamPreviews = streamPreviews;
            this.RemixingSessionId = remixingSessionId;
            this.RemixingSessionIterationId = remixingSessionIterationId;
            this.PromptStrength = promptStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceRemixRequestModel" /> class.
        /// </summary>
        public VoiceRemixRequestModel()
        {
        }
    }
}
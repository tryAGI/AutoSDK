//HintName: G.Models.BodyCreatePodcastV1StudioPodcastsPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreatePodcastV1StudioPodcastsPost
    {
        /// <summary>
        /// The ID of the model to be used for this Studio project, you can query GET /v1/models to list all available models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// The type of podcast to generate. Can be 'conversation', an interaction between two voices, or 'bulletin', a monologue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.PodcastConversationMode, global::G.PodcastBulletinMode> Mode { get; set; } = default!;

        /// <summary>
        /// The source content for the Podcast.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>> Source { get; set; } = default!;

        /// <summary>
        /// Output quality of the generated audio. Must be one of:<br/>
        /// 'standard' - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// 'high' - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side.<br/>
        /// 'ultra' - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side.<br/>
        /// 'ultra_lossless' - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format.<br/>
        /// Default Value: standard
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality_preset")]
        public global::G.BodyCreatePodcastV1StudioPodcastsPostQualityPreset? QualityPreset { get; set; }

        /// <summary>
        /// Duration of the generated podcast. Must be one of:<br/>
        /// short - produces podcasts shorter than 3 minutes.<br/>
        /// default - produces podcasts roughly between 3-7 minutes.<br/>
        /// long - produces podcasts longer than 7 minutes.<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_scale")]
        public global::G.BodyCreatePodcastV1StudioPodcastsPostDurationScale? DurationScale { get; set; }

        /// <summary>
        /// An optional language of the Studio project. Two-letter language code (ISO 639-1).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The intro text that will always be added to the beginning of the podcast.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("intro")]
        public string? Intro { get; set; }

        /// <summary>
        /// The outro text that will always be added to the end of the podcast.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outro")]
        public string? Outro { get; set; }

        /// <summary>
        /// Additional instructions prompt for the podcast generation used to adjust the podcast's style and tone.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions_prompt")]
        public string? InstructionsPrompt { get; set; }

        /// <summary>
        /// A brief summary or highlights of the Studio project's content, providing key points or themes. This should be between 10 and 70 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("highlights")]
        public global::System.Collections.Generic.IList<string>? Highlights { get; set; }

        /// <summary>
        ///     A url that will be called by our service when the Studio project is converted. Request will contain a json blob containing the status of the conversion<br/>
        ///     Messages:<br/>
        ///     1. When project was converted successfully:<br/>
        ///     {<br/>
        ///       type: "project_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         conversion_status: "success",<br/>
        ///         project_snapshot_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         error_details: None,<br/>
        ///       }<br/>
        ///     }<br/>
        ///     2. When project conversion failed:<br/>
        ///     {<br/>
        ///       type: "project_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         conversion_status: "error",<br/>
        ///         project_snapshot_id: None,<br/>
        ///         error_details: "Error details if conversion failed"<br/>
        ///       }<br/>
        ///     }<br/>
        ///     3. When chapter was converted successfully:<br/>
        ///     {<br/>
        ///       type: "chapter_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         chapter_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         conversion_status: "success",<br/>
        ///         chapter_snapshot_id: "23m00Tcm4TlvDq8ikMAV",<br/>
        ///         error_details: None,<br/>
        ///       }<br/>
        ///     }<br/>
        ///     4. When chapter conversion failed:<br/>
        ///     {<br/>
        ///       type: "chapter_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         chapter_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         conversion_status: "error",<br/>
        ///         chapter_snapshot_id: None,<br/>
        ///         error_details: "Error details if conversion failed"<br/>
        ///       }<br/>
        ///     }<br/>
        ///     
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        ///     This parameter controls text normalization with four modes: 'auto', 'on', 'apply_english' and 'off'.<br/>
        ///     When set to 'auto', the system will automatically decide whether to apply text normalization<br/>
        ///     (e.g., spelling out numbers). With 'on', text normalization will always be applied, while<br/>
        ///     with 'off', it will be skipped. 'apply_english' is the same as 'on' but will assume that text is in English.<br/>
        ///     
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_text_normalization")]
        public global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2? ApplyTextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePodcastV1StudioPodcastsPost" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to be used for this Studio project, you can query GET /v1/models to list all available models.
        /// </param>
        /// <param name="mode">
        /// The type of podcast to generate. Can be 'conversation', an interaction between two voices, or 'bulletin', a monologue.
        /// </param>
        /// <param name="source">
        /// The source content for the Podcast.
        /// </param>
        /// <param name="qualityPreset">
        /// Output quality of the generated audio. Must be one of:<br/>
        /// 'standard' - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// 'high' - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side.<br/>
        /// 'ultra' - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side.<br/>
        /// 'ultra_lossless' - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="durationScale">
        /// Duration of the generated podcast. Must be one of:<br/>
        /// short - produces podcasts shorter than 3 minutes.<br/>
        /// default - produces podcasts roughly between 3-7 minutes.<br/>
        /// long - produces podcasts longer than 7 minutes.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="language">
        /// An optional language of the Studio project. Two-letter language code (ISO 639-1).
        /// </param>
        /// <param name="intro">
        /// The intro text that will always be added to the beginning of the podcast.
        /// </param>
        /// <param name="outro">
        /// The outro text that will always be added to the end of the podcast.
        /// </param>
        /// <param name="instructionsPrompt">
        /// Additional instructions prompt for the podcast generation used to adjust the podcast's style and tone.
        /// </param>
        /// <param name="highlights">
        /// A brief summary or highlights of the Studio project's content, providing key points or themes. This should be between 10 and 70 characters.
        /// </param>
        /// <param name="callbackUrl">
        ///     A url that will be called by our service when the Studio project is converted. Request will contain a json blob containing the status of the conversion<br/>
        ///     Messages:<br/>
        ///     1. When project was converted successfully:<br/>
        ///     {<br/>
        ///       type: "project_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         conversion_status: "success",<br/>
        ///         project_snapshot_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         error_details: None,<br/>
        ///       }<br/>
        ///     }<br/>
        ///     2. When project conversion failed:<br/>
        ///     {<br/>
        ///       type: "project_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         conversion_status: "error",<br/>
        ///         project_snapshot_id: None,<br/>
        ///         error_details: "Error details if conversion failed"<br/>
        ///       }<br/>
        ///     }<br/>
        ///     3. When chapter was converted successfully:<br/>
        ///     {<br/>
        ///       type: "chapter_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         chapter_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         conversion_status: "success",<br/>
        ///         chapter_snapshot_id: "23m00Tcm4TlvDq8ikMAV",<br/>
        ///         error_details: None,<br/>
        ///       }<br/>
        ///     }<br/>
        ///     4. When chapter conversion failed:<br/>
        ///     {<br/>
        ///       type: "chapter_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         chapter_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         conversion_status: "error",<br/>
        ///         chapter_snapshot_id: None,<br/>
        ///         error_details: "Error details if conversion failed"<br/>
        ///       }<br/>
        ///     }<br/>
        ///     
        /// </param>
        /// <param name="applyTextNormalization">
        ///     This parameter controls text normalization with four modes: 'auto', 'on', 'apply_english' and 'off'.<br/>
        ///     When set to 'auto', the system will automatically decide whether to apply text normalization<br/>
        ///     (e.g., spelling out numbers). With 'on', text normalization will always be applied, while<br/>
        ///     with 'off', it will be skipped. 'apply_english' is the same as 'on' but will assume that text is in English.<br/>
        ///     
        /// </param>
        public BodyCreatePodcastV1StudioPodcastsPost(
            string modelId,
            global::G.AnyOf<global::G.PodcastConversationMode, global::G.PodcastBulletinMode> mode,
            global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>> source,
            global::G.BodyCreatePodcastV1StudioPodcastsPostQualityPreset? qualityPreset,
            global::G.BodyCreatePodcastV1StudioPodcastsPostDurationScale? durationScale,
            string? language,
            string? intro,
            string? outro,
            string? instructionsPrompt,
            global::System.Collections.Generic.IList<string>? highlights,
            string? callbackUrl,
            global::G.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2? applyTextNormalization)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Mode = mode;
            this.Source = source;
            this.QualityPreset = qualityPreset;
            this.DurationScale = durationScale;
            this.Language = language;
            this.Intro = intro;
            this.Outro = outro;
            this.InstructionsPrompt = instructionsPrompt;
            this.Highlights = highlights;
            this.CallbackUrl = callbackUrl;
            this.ApplyTextNormalization = applyTextNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePodcastV1StudioPodcastsPost" /> class.
        /// </summary>
        public BodyCreatePodcastV1StudioPodcastsPost()
        {
        }
    }
}
//HintName: G.Models.BodyCreatePodcastV1StudioPodcastsPost.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreatePodcastV1StudioPodcastsPost
    {
        /// <summary>
        /// The ID of the model to be used for this Studio project, you can query GET /v1/models to list all available models.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </summary>
        /// <example>21m00Tcm4TlvDq8ikWAM</example>
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
        /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
        /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
        /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::Newtonsoft.Json.JsonProperty("quality_preset")]
        public global::G.BodyCreatePodcastV1StudioPodcastsPostQualityPreset? QualityPreset { get; set; }

        /// <summary>
        /// Duration of the generated podcast. Must be one of:<br/>
        /// short - produces podcasts shorter than 3 minutes.<br/>
        /// default - produces podcasts roughly between 3-7 minutes.<br/>
        /// long - prodces podcasts longer than 7 minutes.<br/>
        /// Default Value: default<br/>
        /// Example: short
        /// </summary>
        /// <example>short</example>
        [global::Newtonsoft.Json.JsonProperty("duration_scale")]
        public global::G.BodyCreatePodcastV1StudioPodcastsPostDurationScale? DurationScale { get; set; }

        /// <summary>
        /// An optional language of the Studio project. Two-letter language code (ISO 639-1).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// A brief summary or highlights of the Studio project's content, providing key points or themes. This should be between 10 and 70 characters.<br/>
        /// Example: [Emphasize the importance of AI on education]
        /// </summary>
        /// <example>[Emphasize the importance of AI on education]</example>
        [global::Newtonsoft.Json.JsonProperty("highlights")]
        public global::System.Collections.Generic.IList<string>? Highlights { get; set; }

        /// <summary>
        /// A url that will be called by our service when the Studio project is converted. Request will contain a json blob containing the status of the conversion<br/>
        /// Example: [https://www.test.com/my-api/projects-status]
        /// </summary>
        /// <example>[https://www.test.com/my-api/projects-status]</example>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePodcastV1StudioPodcastsPost" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to be used for this Studio project, you can query GET /v1/models to list all available models.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="mode">
        /// The type of podcast to generate. Can be 'conversation', an interaction between two voices, or 'bulletin', a monologue.
        /// </param>
        /// <param name="source">
        /// The source content for the Podcast.
        /// </param>
        /// <param name="qualityPreset">
        /// Output quality of the generated audio. Must be one of:<br/>
        /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
        /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
        /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </param>
        /// <param name="durationScale">
        /// Duration of the generated podcast. Must be one of:<br/>
        /// short - produces podcasts shorter than 3 minutes.<br/>
        /// default - produces podcasts roughly between 3-7 minutes.<br/>
        /// long - prodces podcasts longer than 7 minutes.<br/>
        /// Default Value: default<br/>
        /// Example: short
        /// </param>
        /// <param name="language">
        /// An optional language of the Studio project. Two-letter language code (ISO 639-1).<br/>
        /// Example: en
        /// </param>
        /// <param name="highlights">
        /// A brief summary or highlights of the Studio project's content, providing key points or themes. This should be between 10 and 70 characters.<br/>
        /// Example: [Emphasize the importance of AI on education]
        /// </param>
        /// <param name="callbackUrl">
        /// A url that will be called by our service when the Studio project is converted. Request will contain a json blob containing the status of the conversion<br/>
        /// Example: [https://www.test.com/my-api/projects-status]
        /// </param>
        public BodyCreatePodcastV1StudioPodcastsPost(
            string modelId,
            global::G.AnyOf<global::G.PodcastConversationMode, global::G.PodcastBulletinMode> mode,
            global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>> source,
            global::G.BodyCreatePodcastV1StudioPodcastsPostQualityPreset? qualityPreset,
            global::G.BodyCreatePodcastV1StudioPodcastsPostDurationScale? durationScale,
            string? language,
            global::System.Collections.Generic.IList<string>? highlights,
            string? callbackUrl)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Mode = mode;
            this.Source = source;
            this.QualityPreset = qualityPreset;
            this.DurationScale = durationScale;
            this.Language = language;
            this.Highlights = highlights;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePodcastV1StudioPodcastsPost" /> class.
        /// </summary>
        public BodyCreatePodcastV1StudioPodcastsPost()
        {
        }
    }
}
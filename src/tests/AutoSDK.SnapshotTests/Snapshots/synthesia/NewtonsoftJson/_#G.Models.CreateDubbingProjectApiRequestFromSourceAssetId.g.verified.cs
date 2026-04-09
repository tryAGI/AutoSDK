//HintName: G.Models.CreateDubbingProjectApiRequestFromSourceAssetId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingProjectApiRequestFromSourceAssetId
    {
        /// <summary>
        /// The title of the dubbed video to create.<br/>
        /// Example: My dubbed video
        /// </summary>
        /// <example>My dubbed video</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The languages to dub the source media asset to.<br/>
        /// Example: [es-ES, fr-FR]
        /// </summary>
        /// <example>[es-ES, fr-FR]</example>
        [global::Newtonsoft.Json.JsonProperty("targetLanguages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DubbingOutputLanguage> TargetLanguages { get; set; } = default!;

        /// <summary>
        /// Whether to enable lipsync for the dubbed video.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("lipsyncEnabled")]
        public bool? LipsyncEnabled { get; set; }

        /// <summary>
        /// The duration of the video to create.<br/>
        /// Default Value: adaptive<br/>
        /// Example: adaptive
        /// </summary>
        /// <example>adaptive</example>
        [global::Newtonsoft.Json.JsonProperty("videoDuration")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationJsonConverter))]
        public global::G.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration? VideoDuration { get; set; }

        /// <summary>
        /// The visibility of the dubbed video.<br/>
        /// Default Value: private<br/>
        /// Example: private
        /// </summary>
        /// <example>private</example>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityJsonConverter))]
        public global::G.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility? Visibility { get; set; }

        /// <summary>
        /// The ID of the source media asset to create the dubbed video from.<br/>
        /// Example: &lt;uuid&gt;
        /// </summary>
        /// <example>&lt;uuid&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("sourceAssetId", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceAssetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceLanguage", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DubbingInputLanguageJsonConverter))]
        public global::G.DubbingInputLanguage SourceLanguage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectApiRequestFromSourceAssetId" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the dubbed video to create.<br/>
        /// Example: My dubbed video
        /// </param>
        /// <param name="targetLanguages">
        /// The languages to dub the source media asset to.<br/>
        /// Example: [es-ES, fr-FR]
        /// </param>
        /// <param name="sourceAssetId">
        /// The ID of the source media asset to create the dubbed video from.<br/>
        /// Example: &lt;uuid&gt;
        /// </param>
        /// <param name="sourceLanguage"></param>
        /// <param name="lipsyncEnabled">
        /// Whether to enable lipsync for the dubbed video.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="videoDuration">
        /// The duration of the video to create.<br/>
        /// Default Value: adaptive<br/>
        /// Example: adaptive
        /// </param>
        /// <param name="visibility">
        /// The visibility of the dubbed video.<br/>
        /// Default Value: private<br/>
        /// Example: private
        /// </param>
        public CreateDubbingProjectApiRequestFromSourceAssetId(
            string title,
            global::System.Collections.Generic.IList<global::G.DubbingOutputLanguage> targetLanguages,
            string sourceAssetId,
            global::G.DubbingInputLanguage sourceLanguage,
            bool? lipsyncEnabled,
            global::G.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration? videoDuration,
            global::G.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility? visibility)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.LipsyncEnabled = lipsyncEnabled;
            this.VideoDuration = videoDuration;
            this.Visibility = visibility;
            this.SourceAssetId = sourceAssetId ?? throw new global::System.ArgumentNullException(nameof(sourceAssetId));
            this.SourceLanguage = sourceLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectApiRequestFromSourceAssetId" /> class.
        /// </summary>
        public CreateDubbingProjectApiRequestFromSourceAssetId()
        {
        }
    }
}
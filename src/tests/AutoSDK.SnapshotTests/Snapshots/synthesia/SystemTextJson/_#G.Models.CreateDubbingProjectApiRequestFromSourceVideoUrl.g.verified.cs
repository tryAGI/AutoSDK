//HintName: G.Models.CreateDubbingProjectApiRequestFromSourceVideoUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingProjectApiRequestFromSourceVideoUrl
    {
        /// <summary>
        /// The title of the dubbed video to create.<br/>
        /// Example: My dubbed video
        /// </summary>
        /// <example>My dubbed video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The languages to dub the source media asset to.<br/>
        /// Example: [es-ES, fr-FR]
        /// </summary>
        /// <example>[es-ES, fr-FR]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetLanguages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DubbingOutputLanguage> TargetLanguages { get; set; }

        /// <summary>
        /// Whether to enable lipsync for the dubbed video.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lipsyncEnabled")]
        public bool? LipsyncEnabled { get; set; }

        /// <summary>
        /// The duration of the video to create.<br/>
        /// Default Value: adaptive<br/>
        /// Example: adaptive
        /// </summary>
        /// <example>adaptive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoDuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationJsonConverter))]
        public global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration? VideoDuration { get; set; }

        /// <summary>
        /// The visibility of the dubbed video.<br/>
        /// Default Value: private<br/>
        /// Example: private
        /// </summary>
        /// <example>private</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityJsonConverter))]
        public global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility? Visibility { get; set; }

        /// <summary>
        /// The public URL where the video to dub is available. At the moment only supporting s3 signed urls<br/>
        /// Example: s3://
        /// </summary>
        /// <example>s3://</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceVideoUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceVideoUrl { get; set; }

        /// <summary>
        /// The language of the source media asset. If not specified, the language will be detected automatically.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceLanguage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DubbingInputLanguageJsonConverter))]
        public global::G.DubbingInputLanguage? SourceLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectApiRequestFromSourceVideoUrl" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the dubbed video to create.<br/>
        /// Example: My dubbed video
        /// </param>
        /// <param name="targetLanguages">
        /// The languages to dub the source media asset to.<br/>
        /// Example: [es-ES, fr-FR]
        /// </param>
        /// <param name="sourceVideoUrl">
        /// The public URL where the video to dub is available. At the moment only supporting s3 signed urls<br/>
        /// Example: s3://
        /// </param>
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
        /// <param name="sourceLanguage">
        /// The language of the source media asset. If not specified, the language will be detected automatically.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: en
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDubbingProjectApiRequestFromSourceVideoUrl(
            string title,
            global::System.Collections.Generic.IList<global::G.DubbingOutputLanguage> targetLanguages,
            string sourceVideoUrl,
            bool? lipsyncEnabled,
            global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration? videoDuration,
            global::G.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility? visibility,
            global::G.DubbingInputLanguage? sourceLanguage)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.LipsyncEnabled = lipsyncEnabled;
            this.VideoDuration = videoDuration;
            this.Visibility = visibility;
            this.SourceVideoUrl = sourceVideoUrl ?? throw new global::System.ArgumentNullException(nameof(sourceVideoUrl));
            this.SourceLanguage = sourceLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingProjectApiRequestFromSourceVideoUrl" /> class.
        /// </summary>
        public CreateDubbingProjectApiRequestFromSourceVideoUrl()
        {
        }
    }
}
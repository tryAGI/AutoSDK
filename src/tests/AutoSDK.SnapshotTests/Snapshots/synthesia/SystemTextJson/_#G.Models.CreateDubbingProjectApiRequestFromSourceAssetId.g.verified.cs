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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationJsonConverter))]
        public global::G.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration? VideoDuration { get; set; }

        /// <summary>
        /// The visibility of the dubbed video.<br/>
        /// Default Value: private<br/>
        /// Example: private
        /// </summary>
        /// <example>private</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityJsonConverter))]
        public global::G.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility? Visibility { get; set; }

        /// <summary>
        /// The ID of the source media asset to create the dubbed video from.<br/>
        /// Example: &lt;uuid&gt;
        /// </summary>
        /// <example>&lt;uuid&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceAssetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceLanguage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DubbingInputLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingInputLanguage SourceLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
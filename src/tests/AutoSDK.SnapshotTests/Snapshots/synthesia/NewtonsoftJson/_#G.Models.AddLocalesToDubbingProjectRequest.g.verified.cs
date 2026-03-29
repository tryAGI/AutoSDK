//HintName: G.Models.AddLocalesToDubbingProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddLocalesToDubbingProjectRequest
    {
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
        public global::G.AddLocalesToDubbingProjectRequestVideoDuration? VideoDuration { get; set; }

        /// <summary>
        /// The visibility of the dubbed video.<br/>
        /// Default Value: private<br/>
        /// Example: private
        /// </summary>
        /// <example>private</example>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public global::G.AddLocalesToDubbingProjectRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLocalesToDubbingProjectRequest" /> class.
        /// </summary>
        /// <param name="targetLanguages">
        /// The languages to dub the source media asset to.<br/>
        /// Example: [es-ES, fr-FR]
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
        public AddLocalesToDubbingProjectRequest(
            global::System.Collections.Generic.IList<global::G.DubbingOutputLanguage> targetLanguages,
            bool? lipsyncEnabled,
            global::G.AddLocalesToDubbingProjectRequestVideoDuration? videoDuration,
            global::G.AddLocalesToDubbingProjectRequestVisibility? visibility)
        {
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.LipsyncEnabled = lipsyncEnabled;
            this.VideoDuration = videoDuration;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLocalesToDubbingProjectRequest" /> class.
        /// </summary>
        public AddLocalesToDubbingProjectRequest()
        {
        }
    }
}
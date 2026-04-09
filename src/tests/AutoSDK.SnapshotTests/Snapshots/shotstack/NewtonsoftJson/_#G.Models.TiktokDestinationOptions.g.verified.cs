//HintName: G.Models.TiktokDestinationOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pass additional options to control how TikTok publishes video.
    /// </summary>
    public sealed partial class TiktokDestinationOptions
    {
        /// <summary>
        /// A title for the video that will be displayed on TikTok.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The privacy level for the video. Options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`public` - video is visible to everyone&lt;/li&gt;<br/>
        ///   &lt;li&gt;`friends` - video is visible to friends only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`private` - video is only visible to you&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: private
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacyLevel")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TiktokDestinationOptionsPrivacyLevelJsonConverter))]
        public global::G.TiktokDestinationOptionsPrivacyLevel? PrivacyLevel { get; set; }

        /// <summary>
        /// Disable the Duet feature for this video.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disableDuet")]
        public bool? DisableDuet { get; set; }

        /// <summary>
        /// Disable the Stitch feature for this video.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disableStitch")]
        public bool? DisableStitch { get; set; }

        /// <summary>
        /// Disable comments on this video.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disableComment")]
        public bool? DisableComment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TiktokDestinationOptions" /> class.
        /// </summary>
        /// <param name="title">
        /// A title for the video that will be displayed on TikTok.
        /// </param>
        /// <param name="privacyLevel">
        /// The privacy level for the video. Options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`public` - video is visible to everyone&lt;/li&gt;<br/>
        ///   &lt;li&gt;`friends` - video is visible to friends only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`private` - video is only visible to you&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: private
        /// </param>
        /// <param name="disableDuet">
        /// Disable the Duet feature for this video.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableStitch">
        /// Disable the Stitch feature for this video.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableComment">
        /// Disable comments on this video.<br/>
        /// Default Value: false
        /// </param>
        public TiktokDestinationOptions(
            string? title,
            global::G.TiktokDestinationOptionsPrivacyLevel? privacyLevel,
            bool? disableDuet,
            bool? disableStitch,
            bool? disableComment)
        {
            this.Title = title;
            this.PrivacyLevel = privacyLevel;
            this.DisableDuet = disableDuet;
            this.DisableStitch = disableStitch;
            this.DisableComment = disableComment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TiktokDestinationOptions" /> class.
        /// </summary>
        public TiktokDestinationOptions()
        {
        }
    }
}
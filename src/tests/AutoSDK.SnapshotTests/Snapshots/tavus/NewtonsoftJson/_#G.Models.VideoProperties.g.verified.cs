//HintName: G.Models.VideoProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoProperties
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_scroll")]
        public bool? BackgroundScroll { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_scroll_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VideoPropertiesBackgroundScrollTypeJsonConverter))]
        public global::G.VideoPropertiesBackgroundScrollType? BackgroundScrollType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_scroll_depth")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VideoPropertiesBackgroundScrollDepthJsonConverter))]
        public global::G.VideoPropertiesBackgroundScrollDepth? BackgroundScrollDepth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_scroll_return")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VideoPropertiesBackgroundScrollReturnJsonConverter))]
        public global::G.VideoPropertiesBackgroundScrollReturn? BackgroundScrollReturn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoProperties" /> class.
        /// </summary>
        /// <param name="backgroundScroll"></param>
        /// <param name="backgroundScrollType"></param>
        /// <param name="backgroundScrollDepth"></param>
        /// <param name="backgroundScrollReturn"></param>
        public VideoProperties(
            bool? backgroundScroll,
            global::G.VideoPropertiesBackgroundScrollType? backgroundScrollType,
            global::G.VideoPropertiesBackgroundScrollDepth? backgroundScrollDepth,
            global::G.VideoPropertiesBackgroundScrollReturn? backgroundScrollReturn)
        {
            this.BackgroundScroll = backgroundScroll;
            this.BackgroundScrollType = backgroundScrollType;
            this.BackgroundScrollDepth = backgroundScrollDepth;
            this.BackgroundScrollReturn = backgroundScrollReturn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoProperties" /> class.
        /// </summary>
        public VideoProperties()
        {
        }
    }
}
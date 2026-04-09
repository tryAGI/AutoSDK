//HintName: G.Models.VideoSegmentation0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoSegmentation0
    {
        /// <summary>
        /// The segmentation strategy you wish to use.<br/>
        /// **Values**:<br/>
        /// - `fixed`: Creates segments of equal, predetermined length. Use this for consistent timing.<br/>
        /// - `dynamic`: Creates segments of variable length that align with scene boundaries. Use this for content-aware segmentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VideoSegmentation0StrategyJsonConverter))]
        public global::G.VideoSegmentation0Strategy Strategy { get; set; }

        /// <summary>
        /// Configuration for dynamic segmentation. This object is required when `strategy` is `dynamic`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VideoSegmentationOneOf0Dynamic Dynamic { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentation0" /> class.
        /// </summary>
        /// <param name="dynamic">
        /// Configuration for dynamic segmentation. This object is required when `strategy` is `dynamic`.
        /// </param>
        /// <param name="strategy">
        /// The segmentation strategy you wish to use.<br/>
        /// **Values**:<br/>
        /// - `fixed`: Creates segments of equal, predetermined length. Use this for consistent timing.<br/>
        /// - `dynamic`: Creates segments of variable length that align with scene boundaries. Use this for content-aware segmentation.
        /// </param>
        public VideoSegmentation0(
            global::G.VideoSegmentationOneOf0Dynamic dynamic,
            global::G.VideoSegmentation0Strategy strategy)
        {
            this.Strategy = strategy;
            this.Dynamic = dynamic ?? throw new global::System.ArgumentNullException(nameof(dynamic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentation0" /> class.
        /// </summary>
        public VideoSegmentation0()
        {
        }
    }
}
//HintName: G.Models.VideoSegmentation1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for fixed segmentation. This field is required when `strategy` is `fixed`.
    /// </summary>
    public sealed partial class VideoSegmentation1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VideoSegmentation1StrategyJsonConverter))]
        public global::G.VideoSegmentation1Strategy Strategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VideoSegmentationOneOf1Fixed Fixed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentation1" /> class.
        /// </summary>
        /// <param name="fixed"></param>
        /// <param name="strategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegmentation1(
            global::G.VideoSegmentationOneOf1Fixed @fixed,
            global::G.VideoSegmentation1Strategy strategy)
        {
            this.Strategy = strategy;
            this.Fixed = @fixed ?? throw new global::System.ArgumentNullException(nameof(@fixed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentation1" /> class.
        /// </summary>
        public VideoSegmentation1()
        {
        }
    }
}
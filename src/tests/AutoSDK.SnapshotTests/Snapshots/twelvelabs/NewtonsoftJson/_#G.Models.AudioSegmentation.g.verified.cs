//HintName: G.Models.AudioSegmentation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies how the platform divides the audio into segments.
    /// </summary>
    public sealed partial class AudioSegmentation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy")]
        public global::G.AudioSegmentationStrategy Strategy { get; set; }

        /// <summary>
        /// Configuration for fixed segmentation.<br/>
        /// This object is required when the `strategy` field is `fixed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixed", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AudioSegmentationFixed Fixed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegmentation" /> class.
        /// </summary>
        /// <param name="fixed">
        /// Configuration for fixed segmentation.<br/>
        /// This object is required when the `strategy` field is `fixed`.
        /// </param>
        /// <param name="strategy"></param>
        public AudioSegmentation(
            global::G.AudioSegmentationFixed @fixed,
            global::G.AudioSegmentationStrategy strategy)
        {
            this.Strategy = strategy;
            this.Fixed = @fixed ?? throw new global::System.ArgumentNullException(nameof(@fixed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegmentation" /> class.
        /// </summary>
        public AudioSegmentation()
        {
        }
    }
}
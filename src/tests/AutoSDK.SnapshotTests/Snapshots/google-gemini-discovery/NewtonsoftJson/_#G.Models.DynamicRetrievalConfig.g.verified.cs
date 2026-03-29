//HintName: G.Models.DynamicRetrievalConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes the options to customize dynamic retrieval.
    /// </summary>
    public sealed partial class DynamicRetrievalConfig
    {
        /// <summary>
        /// The mode of the predictor to be used in dynamic retrieval.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.DynamicRetrievalConfigMode? Mode { get; set; }

        /// <summary>
        /// The threshold to be used in dynamic retrieval. If not set, a system default value is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamicThreshold")]
        public float? DynamicThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicRetrievalConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode of the predictor to be used in dynamic retrieval.
        /// </param>
        /// <param name="dynamicThreshold">
        /// The threshold to be used in dynamic retrieval. If not set, a system default value is used.
        /// </param>
        public DynamicRetrievalConfig(
            global::G.DynamicRetrievalConfigMode? mode,
            float? dynamicThreshold)
        {
            this.Mode = mode;
            this.DynamicThreshold = dynamicThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicRetrievalConfig" /> class.
        /// </summary>
        public DynamicRetrievalConfig()
        {
        }
    }
}
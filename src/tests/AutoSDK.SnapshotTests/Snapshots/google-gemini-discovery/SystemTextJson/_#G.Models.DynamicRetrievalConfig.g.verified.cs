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
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DynamicRetrievalConfigModeJsonConverter))]
        public global::G.DynamicRetrievalConfigMode? Mode { get; set; }

        /// <summary>
        /// The threshold to be used in dynamic retrieval. If not set, a system default value is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicThreshold")]
        public float? DynamicThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
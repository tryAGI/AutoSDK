//HintName: G.Models.MultiVectorConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiVectorConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MultiVectorComparatorJsonConverter))]
        public global::G.MultiVectorComparator Comparator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiVectorConfig" /> class.
        /// </summary>
        /// <param name="comparator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiVectorConfig(
            global::G.MultiVectorComparator comparator)
        {
            this.Comparator = comparator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiVectorConfig" /> class.
        /// </summary>
        public MultiVectorConfig()
        {
        }
    }
}
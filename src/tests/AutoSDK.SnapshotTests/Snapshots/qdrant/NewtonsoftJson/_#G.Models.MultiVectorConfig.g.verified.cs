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
        [global::Newtonsoft.Json.JsonProperty("comparator")]
        public global::G.MultiVectorComparator Comparator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiVectorConfig" /> class.
        /// </summary>
        /// <param name="comparator"></param>
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
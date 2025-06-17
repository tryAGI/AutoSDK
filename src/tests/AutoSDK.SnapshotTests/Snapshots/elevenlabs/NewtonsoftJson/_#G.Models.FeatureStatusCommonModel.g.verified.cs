//HintName: G.Models.FeatureStatusCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeatureStatusCommonModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("used")]
        public bool? Used { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureStatusCommonModel" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="used">
        /// Default Value: false
        /// </param>
        public FeatureStatusCommonModel(
            bool? enabled,
            bool? used)
        {
            this.Enabled = enabled;
            this.Used = used;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureStatusCommonModel" /> class.
        /// </summary>
        public FeatureStatusCommonModel()
        {
        }
    }
}
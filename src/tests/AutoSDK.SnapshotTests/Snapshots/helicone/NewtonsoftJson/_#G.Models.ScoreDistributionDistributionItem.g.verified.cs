//HintName: G.Models.ScoreDistributionDistributionItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreDistributionDistributionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upper", Required = global::Newtonsoft.Json.Required.Always)]
        public double Upper { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lower", Required = global::Newtonsoft.Json.Required.Always)]
        public double Lower { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDistributionDistributionItem" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="upper"></param>
        /// <param name="lower"></param>
        public ScoreDistributionDistributionItem(
            double value,
            double upper,
            double lower)
        {
            this.Value = value;
            this.Upper = upper;
            this.Lower = lower;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreDistributionDistributionItem" /> class.
        /// </summary>
        public ScoreDistributionDistributionItem()
        {
        }
    }
}
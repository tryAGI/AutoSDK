//HintName: G.Models.PercentageValues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PercentageValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p50")]
        public double? P50 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90")]
        public double? P90 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p99")]
        public double? P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValues" /> class.
        /// </summary>
        /// <param name="p50"></param>
        /// <param name="p90"></param>
        /// <param name="p99"></param>
        public PercentageValues(
            double? p50,
            double? p90,
            double? p99)
        {
            this.P50 = p50;
            this.P90 = p90;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValues" /> class.
        /// </summary>
        public PercentageValues()
        {
        }
    }
}
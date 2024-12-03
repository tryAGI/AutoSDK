//HintName: G.Models.GlobalAdvisoryEpss.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalAdvisoryEpss
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percentage")]
        public double? Percentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percentile")]
        public double? Percentile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisoryEpss" /> class.
        /// </summary>
        /// <param name="percentage"></param>
        /// <param name="percentile"></param>
        public GlobalAdvisoryEpss(
            double? percentage,
            double? percentile)
        {
            this.Percentage = percentage;
            this.Percentile = percentile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalAdvisoryEpss" /> class.
        /// </summary>
        public GlobalAdvisoryEpss()
        {
        }
    }
}
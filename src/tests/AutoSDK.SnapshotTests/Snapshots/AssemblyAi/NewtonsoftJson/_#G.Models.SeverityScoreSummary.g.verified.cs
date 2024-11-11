//HintName: G.Models.SeverityScoreSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SeverityScoreSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("low", Required = global::Newtonsoft.Json.Required.Always)]
        public double Low { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("medium", Required = global::Newtonsoft.Json.Required.Always)]
        public double Medium { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("high", Required = global::Newtonsoft.Json.Required.Always)]
        public double High { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeverityScoreSummary" /> class.
        /// </summary>
        /// <param name="low"></param>
        /// <param name="medium"></param>
        /// <param name="high"></param>
        public SeverityScoreSummary(
            double low,
            double medium,
            double high)
        {
            this.Low = low;
            this.Medium = medium;
            this.High = high;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeverityScoreSummary" /> class.
        /// </summary>
        public SeverityScoreSummary()
        {
        }
    }
}
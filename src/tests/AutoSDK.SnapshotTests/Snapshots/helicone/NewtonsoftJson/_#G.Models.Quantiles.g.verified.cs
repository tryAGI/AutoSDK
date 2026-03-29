//HintName: G.Models.Quantiles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Quantiles
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p75", Required = global::Newtonsoft.Json.Required.Always)]
        public double P75 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90", Required = global::Newtonsoft.Json.Required.Always)]
        public double P90 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p95", Required = global::Newtonsoft.Json.Required.Always)]
        public double P95 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p99", Required = global::Newtonsoft.Json.Required.Always)]
        public double P99 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantiles" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="p75"></param>
        /// <param name="p90"></param>
        /// <param name="p95"></param>
        /// <param name="p99"></param>
        public Quantiles(
            global::System.DateTime time,
            double p75,
            double p90,
            double p95,
            double p99)
        {
            this.Time = time;
            this.P75 = p75;
            this.P90 = p90;
            this.P95 = p95;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantiles" /> class.
        /// </summary>
        public Quantiles()
        {
        }
    }
}
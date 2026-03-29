//HintName: G.Models.UsageStatsResponseBillingPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageStatsResponseBillingPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("daysTotal", Required = global::Newtonsoft.Json.Required.Always)]
        public double DaysTotal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("daysElapsed", Required = global::Newtonsoft.Json.Required.Always)]
        public double DaysElapsed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public string End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public string Start { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponseBillingPeriod" /> class.
        /// </summary>
        /// <param name="daysTotal"></param>
        /// <param name="daysElapsed"></param>
        /// <param name="end"></param>
        /// <param name="start"></param>
        public UsageStatsResponseBillingPeriod(
            double daysTotal,
            double daysElapsed,
            string end,
            string start)
        {
            this.DaysTotal = daysTotal;
            this.DaysElapsed = daysElapsed;
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponseBillingPeriod" /> class.
        /// </summary>
        public UsageStatsResponseBillingPeriod()
        {
        }
    }
}
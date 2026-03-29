//HintName: G.Models.DailyCostBucket.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Daily cost bucket.
    /// </summary>
    public sealed partial class DailyCostBucket
    {
        /// <summary>
        /// The date of the cost bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("day", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Day { get; set; } = default!;

        /// <summary>
        /// The cost of the cost bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public string Cost { get; set; } = default!;

        /// <summary>
        /// The cost per metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_per_metric", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> CostPerMetric { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyCostBucket" /> class.
        /// </summary>
        /// <param name="day">
        /// The date of the cost bucket
        /// </param>
        /// <param name="cost">
        /// The cost of the cost bucket
        /// </param>
        /// <param name="costPerMetric">
        /// The cost per metric
        /// </param>
        public DailyCostBucket(
            global::System.DateTime day,
            string cost,
            global::System.Collections.Generic.Dictionary<string, string> costPerMetric)
        {
            this.Day = day;
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
            this.CostPerMetric = costPerMetric ?? throw new global::System.ArgumentNullException(nameof(costPerMetric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyCostBucket" /> class.
        /// </summary>
        public DailyCostBucket()
        {
        }
    }
}
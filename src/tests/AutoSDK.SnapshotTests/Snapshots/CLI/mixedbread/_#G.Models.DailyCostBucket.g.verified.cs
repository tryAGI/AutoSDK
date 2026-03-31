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
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// The cost of the cost bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cost { get; set; }

        /// <summary>
        /// The cost per metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> CostPerMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
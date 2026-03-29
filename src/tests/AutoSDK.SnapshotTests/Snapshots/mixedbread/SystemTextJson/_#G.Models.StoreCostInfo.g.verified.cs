//HintName: G.Models.StoreCostInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cost information for a store.
    /// </summary>
    public sealed partial class StoreCostInfo
    {
        /// <summary>
        /// The ID of the store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// The cost
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
        /// Initializes a new instance of the <see cref="StoreCostInfo" /> class.
        /// </summary>
        /// <param name="storeId">
        /// The ID of the store
        /// </param>
        /// <param name="cost">
        /// The cost
        /// </param>
        /// <param name="costPerMetric">
        /// The cost per metric
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreCostInfo(
            string storeId,
            string cost,
            global::System.Collections.Generic.Dictionary<string, string> costPerMetric)
        {
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
            this.CostPerMetric = costPerMetric ?? throw new global::System.ArgumentNullException(nameof(costPerMetric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreCostInfo" /> class.
        /// </summary>
        public StoreCostInfo()
        {
        }
    }
}
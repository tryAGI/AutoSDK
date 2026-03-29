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
        [global::Newtonsoft.Json.JsonProperty("store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// The cost
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
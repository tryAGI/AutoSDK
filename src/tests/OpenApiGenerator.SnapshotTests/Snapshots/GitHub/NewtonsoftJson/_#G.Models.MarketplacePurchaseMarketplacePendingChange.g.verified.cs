//HintName: G.Models.MarketplacePurchaseMarketplacePendingChange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketplacePurchaseMarketplacePendingChange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_installed")]
        public bool IsInstalled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_count")]
        public int? UnitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Marketplace Listing Plan
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public MarketplaceListingPlan? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
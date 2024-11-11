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
        [global::System.Text.Json.Serialization.JsonPropertyName("is_installed")]
        public bool? IsInstalled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_count")]
        public int? UnitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Marketplace Listing Plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public global::G.MarketplaceListingPlan? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePurchaseMarketplacePendingChange" /> class.
        /// </summary>
        /// <param name="isInstalled"></param>
        /// <param name="effectiveDate"></param>
        /// <param name="unitCount"></param>
        /// <param name="id"></param>
        /// <param name="plan">
        /// Marketplace Listing Plan
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MarketplacePurchaseMarketplacePendingChange(
            bool? isInstalled,
            string? effectiveDate,
            int? unitCount,
            int? id,
            global::G.MarketplaceListingPlan? plan)
        {
            this.IsInstalled = isInstalled;
            this.EffectiveDate = effectiveDate;
            this.UnitCount = unitCount;
            this.Id = id;
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePurchaseMarketplacePendingChange" /> class.
        /// </summary>
        public MarketplacePurchaseMarketplacePendingChange()
        {
        }
    }
}
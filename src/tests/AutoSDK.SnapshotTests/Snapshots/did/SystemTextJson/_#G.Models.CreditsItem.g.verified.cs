//HintName: G.Models.CreditsItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Remaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpireAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_from")]
        public string? ValidFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_id")]
        public string? PriceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_group")]
        public string? PlanGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_billing_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreditsItemProductBillingIntervalJsonConverter))]
        public global::G.CreditsItemProductBillingInterval? ProductBillingInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsItem" /> class.
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="remaining"></param>
        /// <param name="total"></param>
        /// <param name="expireAt"></param>
        /// <param name="validFrom"></param>
        /// <param name="productId"></param>
        /// <param name="priceId"></param>
        /// <param name="planGroup"></param>
        /// <param name="productBillingInterval"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsItem(
            string ownerId,
            string createdAt,
            string modifiedAt,
            double remaining,
            double total,
            string expireAt,
            string? validFrom,
            string? productId,
            string? priceId,
            string? planGroup,
            global::G.CreditsItemProductBillingInterval? productBillingInterval)
        {
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.Remaining = remaining;
            this.Total = total;
            this.ExpireAt = expireAt ?? throw new global::System.ArgumentNullException(nameof(expireAt));
            this.ValidFrom = validFrom;
            this.ProductId = productId;
            this.PriceId = priceId;
            this.PlanGroup = planGroup;
            this.ProductBillingInterval = productBillingInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsItem" /> class.
        /// </summary>
        public CreditsItem()
        {
        }
    }
}
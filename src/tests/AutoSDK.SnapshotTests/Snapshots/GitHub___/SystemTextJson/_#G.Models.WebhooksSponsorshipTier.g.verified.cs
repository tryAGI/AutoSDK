//HintName: G.Models.WebhooksSponsorshipTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `tier_changed` and `pending_tier_change` will include the original tier before the change or pending change. For more information, see the pending tier change payload.
    /// </summary>
    public sealed partial class WebhooksSponsorshipTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom_ammount")]
        public bool? IsCustomAmmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom_amount")]
        public bool? IsCustomAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_one_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOneTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_price_in_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyPriceInCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_price_in_dollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyPriceInDollars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSponsorshipTier" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="isCustomAmmount"></param>
        /// <param name="isCustomAmount"></param>
        /// <param name="isOneTime"></param>
        /// <param name="monthlyPriceInCents"></param>
        /// <param name="monthlyPriceInDollars"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhooksSponsorshipTier(
            string createdAt,
            string description,
            bool isOneTime,
            int monthlyPriceInCents,
            int monthlyPriceInDollars,
            string name,
            string nodeId,
            bool? isCustomAmmount,
            bool? isCustomAmount)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IsOneTime = isOneTime;
            this.MonthlyPriceInCents = monthlyPriceInCents;
            this.MonthlyPriceInDollars = monthlyPriceInDollars;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.IsCustomAmmount = isCustomAmmount;
            this.IsCustomAmount = isCustomAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSponsorshipTier" /> class.
        /// </summary>
        public WebhooksSponsorshipTier()
        {
        }
    }
}
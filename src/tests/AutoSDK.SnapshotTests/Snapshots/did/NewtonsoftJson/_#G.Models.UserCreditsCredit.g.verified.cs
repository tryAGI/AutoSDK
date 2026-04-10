//HintName: G.Models.UserCreditsCredit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserCreditsCredit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remaining", Required = global::Newtonsoft.Json.Required.Always)]
        public double Remaining { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expire_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpireAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valid_from")]
        public string? ValidFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_id")]
        public string? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price_id")]
        public string? PriceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan_group")]
        public string? PlanGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_billing_interval")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UserCreditsCreditProductBillingIntervalJsonConverter))]
        public global::G.UserCreditsCreditProductBillingInterval? ProductBillingInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreditsCredit" /> class.
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
        public UserCreditsCredit(
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
            global::G.UserCreditsCreditProductBillingInterval? productBillingInterval)
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
        /// Initializes a new instance of the <see cref="UserCreditsCredit" /> class.
        /// </summary>
        public UserCreditsCredit()
        {
        }
    }
}
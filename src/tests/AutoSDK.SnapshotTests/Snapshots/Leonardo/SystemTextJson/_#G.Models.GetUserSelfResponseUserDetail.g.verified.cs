//HintName: G.Models.GetUserSelfResponseUserDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "user_details"
    /// </summary>
    public sealed partial class GetUserSelfResponseUserDetail
    {
        /// <summary>
        /// columns and relationships of "users"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.GetUserSelfResponseUserDetailUser? User { get; set; }

        /// <summary>
        /// User Plan Token Renewal Date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenRenewalDate")]
        public string? TokenRenewalDate { get; set; }

        /// <summary>
        /// Current balance of paid tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paidTokens")]
        public int? PaidTokens { get; set; }

        /// <summary>
        /// Current balance of user plan subscription tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionTokens")]
        public int? SubscriptionTokens { get; set; }

        /// <summary>
        /// Current balance of user plan GPT tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionGptTokens")]
        public int? SubscriptionGptTokens { get; set; }

        /// <summary>
        /// Current balance of model training tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionModelTokens")]
        public int? SubscriptionModelTokens { get; set; }

        /// <summary>
        /// API Concurrency Slots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiConcurrencySlots")]
        public int? ApiConcurrencySlots { get; set; }

        /// <summary>
        /// Current balance of API paid tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiPaidTokens")]
        public int? ApiPaidTokens { get; set; }

        /// <summary>
        /// Current balance of Enterprise API subscriptions tokens the user has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiSubscriptionTokens")]
        public int? ApiSubscriptionTokens { get; set; }

        /// <summary>
        /// API Plan Token Renewal Date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiPlanTokenRenewalDate")]
        public string? ApiPlanTokenRenewalDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
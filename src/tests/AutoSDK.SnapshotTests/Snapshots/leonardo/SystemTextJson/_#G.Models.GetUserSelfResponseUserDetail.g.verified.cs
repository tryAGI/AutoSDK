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

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponseUserDetail" /> class.
        /// </summary>
        /// <param name="user">
        /// columns and relationships of "users"
        /// </param>
        /// <param name="tokenRenewalDate">
        /// User Plan Token Renewal Date.
        /// </param>
        /// <param name="paidTokens">
        /// Current balance of paid tokens the user has.
        /// </param>
        /// <param name="subscriptionTokens">
        /// Current balance of user plan subscription tokens the user has.
        /// </param>
        /// <param name="subscriptionGptTokens">
        /// Current balance of user plan GPT tokens the user has.
        /// </param>
        /// <param name="subscriptionModelTokens">
        /// Current balance of model training tokens the user has.
        /// </param>
        /// <param name="apiConcurrencySlots">
        /// API Concurrency Slots.
        /// </param>
        /// <param name="apiPaidTokens">
        /// Current balance of API paid tokens the user has.
        /// </param>
        /// <param name="apiSubscriptionTokens">
        /// Current balance of Enterprise API subscriptions tokens the user has.
        /// </param>
        /// <param name="apiPlanTokenRenewalDate">
        /// API Plan Token Renewal Date.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserSelfResponseUserDetail(
            global::G.GetUserSelfResponseUserDetailUser? user,
            string? tokenRenewalDate,
            int? paidTokens,
            int? subscriptionTokens,
            int? subscriptionGptTokens,
            int? subscriptionModelTokens,
            int? apiConcurrencySlots,
            int? apiPaidTokens,
            int? apiSubscriptionTokens,
            string? apiPlanTokenRenewalDate)
        {
            this.User = user;
            this.TokenRenewalDate = tokenRenewalDate;
            this.PaidTokens = paidTokens;
            this.SubscriptionTokens = subscriptionTokens;
            this.SubscriptionGptTokens = subscriptionGptTokens;
            this.SubscriptionModelTokens = subscriptionModelTokens;
            this.ApiConcurrencySlots = apiConcurrencySlots;
            this.ApiPaidTokens = apiPaidTokens;
            this.ApiSubscriptionTokens = apiSubscriptionTokens;
            this.ApiPlanTokenRenewalDate = apiPlanTokenRenewalDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponseUserDetail" /> class.
        /// </summary>
        public GetUserSelfResponseUserDetail()
        {
        }
    }
}
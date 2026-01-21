//HintName: G.Models.PostApiSubscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update API settings. Fields which are omitted will be ignored.<br/>
    /// Example: {"recharge_settings":{"minimum_balance_threshold":{"amount":1050,"currency_code":"USD"},"top_up_balance":{"amount":1050,"currency_code":"USD"}}}
    /// </summary>
    public sealed partial class PostApiSubscriptionRequest
    {
        /// <summary>
        /// The current recharge settings for the API subscription.<br/>
        /// Example: {"minimum_balance_threshold":{"amount":1050,"currency_code":"USD"},"top_up_balance":{"amount":1050,"currency_code":"USD"}}
        /// </summary>
        /// <example>{"minimum_balance_threshold":{"amount":1050,"currency_code":"USD"},"top_up_balance":{"amount":1050,"currency_code":"USD"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharge_settings")]
        public global::G.RechargeSettings? RechargeSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="rechargeSettings">
        /// The current recharge settings for the API subscription.<br/>
        /// Example: {"minimum_balance_threshold":{"amount":1050,"currency_code":"USD"},"top_up_balance":{"amount":1050,"currency_code":"USD"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostApiSubscriptionRequest(
            global::G.RechargeSettings? rechargeSettings)
        {
            this.RechargeSettings = rechargeSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiSubscriptionRequest" /> class.
        /// </summary>
        public PostApiSubscriptionRequest()
        {
        }
    }
}
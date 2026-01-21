//HintName: G.Models.RechargeSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current recharge settings for the API subscription.<br/>
    /// Example: {"minimum_balance_threshold":{"amount":1050,"currency_code":"USD"},"top_up_balance":{"amount":1050,"currency_code":"USD"}}
    /// </summary>
    public sealed partial class RechargeSettings
    {
        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::Newtonsoft.Json.JsonProperty("top_up_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Price TopUpBalance { get; set; } = default!;

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::Newtonsoft.Json.JsonProperty("minimum_balance_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Price MinimumBalanceThreshold { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RechargeSettings" /> class.
        /// </summary>
        /// <param name="topUpBalance">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="minimumBalanceThreshold">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        public RechargeSettings(
            global::G.Price topUpBalance,
            global::G.Price minimumBalanceThreshold)
        {
            this.TopUpBalance = topUpBalance ?? throw new global::System.ArgumentNullException(nameof(topUpBalance));
            this.MinimumBalanceThreshold = minimumBalanceThreshold ?? throw new global::System.ArgumentNullException(nameof(minimumBalanceThreshold));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RechargeSettings" /> class.
        /// </summary>
        public RechargeSettings()
        {
        }
    }
}
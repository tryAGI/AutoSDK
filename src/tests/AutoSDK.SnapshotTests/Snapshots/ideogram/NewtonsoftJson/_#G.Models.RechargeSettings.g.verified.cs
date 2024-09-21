//HintName: G.Models.RechargeSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current recharge settings for the API subscription.
    /// </summary>
    public sealed partial class RechargeSettings
    {
        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_up_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Price TopUpBalance { get; set; } = default!;

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimum_balance_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Price MinimumBalanceThreshold { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
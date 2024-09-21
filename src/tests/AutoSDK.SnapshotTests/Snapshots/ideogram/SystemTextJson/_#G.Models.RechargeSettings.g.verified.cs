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
        [global::System.Text.Json.Serialization.JsonPropertyName("top_up_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Price TopUpBalance { get; set; }

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_balance_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Price MinimumBalanceThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
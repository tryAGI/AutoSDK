//HintName: G.Models.PostApiSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The updated API subscription.
    /// </summary>
    public sealed partial class PostApiSubscriptionResponse
    {
        /// <summary>
        /// The current recharge settings for the API subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recharge_settings")]
        public global::G.RechargeSettings? RechargeSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.PostApiSubscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update API settings. Fields which are omitted will be ignored.
    /// </summary>
    public sealed partial class PostApiSubscriptionRequest
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
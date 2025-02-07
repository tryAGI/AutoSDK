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
        /// The current recharge settings for the API subscription.
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
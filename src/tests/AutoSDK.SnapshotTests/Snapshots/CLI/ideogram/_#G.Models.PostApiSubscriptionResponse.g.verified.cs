﻿//HintName: G.Models.PostApiSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The updated API subscription.
    /// </summary>
    public sealed partial class PostApiSubscriptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharge_settings")]
        public global::G.RechargeSettingsResponse? RechargeSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="rechargeSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostApiSubscriptionResponse(
            global::G.RechargeSettingsResponse? rechargeSettings)
        {
            this.RechargeSettings = rechargeSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiSubscriptionResponse" /> class.
        /// </summary>
        public PostApiSubscriptionResponse()
        {
        }
    }
}
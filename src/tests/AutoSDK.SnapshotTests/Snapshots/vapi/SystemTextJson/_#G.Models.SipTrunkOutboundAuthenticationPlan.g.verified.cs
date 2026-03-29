//HintName: G.Models.SipTrunkOutboundAuthenticationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SipTrunkOutboundAuthenticationPlan
    {
        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authPassword")]
        public string? AuthPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authUsername")]
        public string? AuthUsername { get; set; }

        /// <summary>
        /// This can be used to configure if SIP register is required by the SIP trunk. If not provided, no SIP registration will be attempted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipRegisterPlan")]
        public global::G.SipTrunkOutboundSipRegisterPlan? SipRegisterPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipTrunkOutboundAuthenticationPlan" /> class.
        /// </summary>
        /// <param name="authPassword">
        /// This is not returned in the API.
        /// </param>
        /// <param name="authUsername"></param>
        /// <param name="sipRegisterPlan">
        /// This can be used to configure if SIP register is required by the SIP trunk. If not provided, no SIP registration will be attempted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SipTrunkOutboundAuthenticationPlan(
            string? authPassword,
            string? authUsername,
            global::G.SipTrunkOutboundSipRegisterPlan? sipRegisterPlan)
        {
            this.AuthPassword = authPassword;
            this.AuthUsername = authUsername;
            this.SipRegisterPlan = sipRegisterPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipTrunkOutboundAuthenticationPlan" /> class.
        /// </summary>
        public SipTrunkOutboundAuthenticationPlan()
        {
        }
    }
}
//HintName: G.Models.SipTrunkOutboundSipRegisterPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SipTrunkOutboundSipRegisterPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realm")]
        public string? Realm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipTrunkOutboundSipRegisterPlan" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="username"></param>
        /// <param name="realm"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SipTrunkOutboundSipRegisterPlan(
            string? domain,
            string? username,
            string? realm)
        {
            this.Domain = domain;
            this.Username = username;
            this.Realm = realm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipTrunkOutboundSipRegisterPlan" /> class.
        /// </summary>
        public SipTrunkOutboundSipRegisterPlan()
        {
        }
    }
}
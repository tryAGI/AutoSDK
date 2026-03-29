//HintName: G.Models.PostToolRouterSessionRequestConnectedAccounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed<br/>
    /// Example: {"github":"ca_34454545454545"}
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestConnectedAccounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
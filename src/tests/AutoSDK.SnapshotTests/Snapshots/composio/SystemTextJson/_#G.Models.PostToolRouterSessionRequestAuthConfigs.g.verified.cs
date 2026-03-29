//HintName: G.Models.PostToolRouterSessionRequestAuthConfigs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
    /// Example: {"gmail":"ac_1223434343","slack":"ac_23343434343434"}
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestAuthConfigs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
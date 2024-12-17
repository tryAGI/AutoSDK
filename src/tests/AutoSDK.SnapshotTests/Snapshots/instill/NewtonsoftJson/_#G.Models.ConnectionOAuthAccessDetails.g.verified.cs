//HintName: G.Models.ConnectionOAuthAccessDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When the connection method is METHOD_OAUTH, the access token might come<br/>
    /// with some extra information that might vary across vendors. This<br/>
    /// information is passed as connection metadata.
    /// </summary>
    public sealed partial class ConnectionOAuthAccessDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
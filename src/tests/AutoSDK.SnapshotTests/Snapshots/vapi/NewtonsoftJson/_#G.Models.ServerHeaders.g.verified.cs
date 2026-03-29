//HintName: G.Models.ServerHeaders.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// These are the headers to include in the request.<br/>
    /// Each key-value pair represents a header name and its value.<br/>
    /// Note: Specifying an Authorization header here will override the authorization provided by the `credentialId` (if provided). This is an anti-pattern and should be avoided outside of edge case scenarios.
    /// </summary>
    public sealed partial class ServerHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.LogResponseHeaders.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response headers (only present when debug logging is enabled or request failed)<br/>
    /// Example: {"Content-Type":"application/json"}
    /// </summary>
    public sealed partial class LogResponseHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.AgentSessionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary metadata associated with the session.<br/>
    /// Example: {"customer_id":"12345","priority":"high","channel":"web_chat"}
    /// </summary>
    public sealed partial class AgentSessionMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
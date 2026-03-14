//HintName: G.Models.CreateAgentSessionRequestMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary metadata associated with the session.<br/>
    /// Default Value: {}<br/>
    /// Example: {"customer_id":"12345","priority":"medium","channel":"web_chat"}
    /// </summary>
    public sealed partial class CreateAgentSessionRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
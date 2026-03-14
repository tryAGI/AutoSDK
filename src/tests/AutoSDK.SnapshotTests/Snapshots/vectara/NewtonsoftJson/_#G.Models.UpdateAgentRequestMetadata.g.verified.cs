//HintName: G.Models.UpdateAgentRequestMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary metadata associated with the agent. Set to null to clear.<br/>
    /// Example: {"department":"customer_service","version":"1.1.0","owner":"support-team","last_reviewed":"2024-01-15"}
    /// </summary>
    public sealed partial class UpdateAgentRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
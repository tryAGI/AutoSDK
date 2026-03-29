//HintName: G.Models.UpdateAgentMessageBufferAutoclear.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.
    /// </summary>
    public sealed partial class UpdateAgentMessageBufferAutoclear
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
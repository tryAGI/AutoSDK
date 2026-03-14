//HintName: G.Models.SubAgentConfigurationSessionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional metadata to associate with the sub-agent session. Can contain any key-value pairs.<br/>
    /// Default Value: {}<br/>
    /// Example: {"source":"parent_agent","task_type":"code_review"}
    /// </summary>
    public sealed partial class SubAgentConfigurationSessionMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
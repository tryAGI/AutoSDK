//HintName: G.Models.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesUpdateCurrentTemplateFromAgentFileNoProjectRequest
    {
        /// <summary>
        /// The agent file to update the current template version from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_file_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> AgentFileJson { get; set; }

        /// <summary>
        /// If true, update existing custom tools source_code and json_schema (source_type cannot be changed)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_existing_tools")]
        public bool? UpdateExistingTools { get; set; }

        /// <summary>
        /// If true, Letta will automatically save any changes as a version before updating the template<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_existing_changes")]
        public bool? SaveExistingChanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesUpdateCurrentTemplateFromAgentFileNoProjectRequest" /> class.
        /// </summary>
        /// <param name="agentFileJson">
        /// The agent file to update the current template version from
        /// </param>
        /// <param name="updateExistingTools">
        /// If true, update existing custom tools source_code and json_schema (source_type cannot be changed)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="saveExistingChanges">
        /// If true, Letta will automatically save any changes as a version before updating the template<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesUpdateCurrentTemplateFromAgentFileNoProjectRequest(
            global::System.Collections.Generic.Dictionary<string, object?> agentFileJson,
            bool? updateExistingTools,
            bool? saveExistingChanges)
        {
            this.AgentFileJson = agentFileJson ?? throw new global::System.ArgumentNullException(nameof(agentFileJson));
            this.UpdateExistingTools = updateExistingTools;
            this.SaveExistingChanges = saveExistingChanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesUpdateCurrentTemplateFromAgentFileNoProjectRequest" /> class.
        /// </summary>
        public TemplatesUpdateCurrentTemplateFromAgentFileNoProjectRequest()
        {
        }
    }
}
//HintName: G.IInternalTemplatesClient.CreateInternalTemplateAgent.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IInternalTemplatesClient
    {
        /// <summary>
        /// Create Agent<br/>
        /// Create a new agent with template-related fields.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> CreateInternalTemplateAgentAsync(

            global::G.InternalTemplateAgentCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create a new agent with template-related fields.
        /// </summary>
        /// <param name="name">
        /// The name of the agent.
        /// </param>
        /// <param name="memoryBlocks">
        /// The blocks to create in the agent's in-context memory.
        /// </param>
        /// <param name="tools">
        /// The tools used by the agent.
        /// </param>
        /// <param name="toolIds">
        /// The ids of the tools used by the agent.
        /// </param>
        /// <param name="folderIds">
        /// The ids of the folders used by the agent.
        /// </param>
        /// <param name="blockIds">
        /// The ids of the blocks used by the agent.
        /// </param>
        /// <param name="toolRules">
        /// The tool rules governing the agent.
        /// </param>
        /// <param name="tags">
        /// The tags associated with the agent.
        /// </param>
        /// <param name="system">
        /// The system prompt used by the agent.
        /// </param>
        /// <param name="agentType">
        /// The type of agent.
        /// </param>
        /// <param name="initialMessageSequence">
        /// The initial set of messages to put in the agent's in-context memory.
        /// </param>
        /// <param name="includeBaseTools">
        /// If true, attaches the Letta core tools (e.g. core_memory related functions).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeMultiAgentTools">
        /// If true, attaches the Letta multi-agent tools (e.g. sending a message to another agent).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeBaseToolRules">
        /// If true, attaches the Letta base tool rules (e.g. deny all tools not explicitly allowed).
        /// </param>
        /// <param name="description">
        /// The description of the agent.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the agent.
        /// </param>
        /// <param name="model">
        /// The model handle for the agent to use (format: provider/model-name).
        /// </param>
        /// <param name="embedding">
        /// The embedding model handle used by the agent (format: provider/model-name).
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for the agent.
        /// </param>
        /// <param name="compactionSettings">
        /// The compaction settings configuration used for compaction.
        /// </param>
        /// <param name="contextWindowLimit">
        /// The context window limit used by the agent.
        /// </param>
        /// <param name="secrets">
        /// The environment variables for tool execution specific to this agent.
        /// </param>
        /// <param name="templateId">
        /// The id of the template.
        /// </param>
        /// <param name="baseTemplateId">
        /// The id of the base template.
        /// </param>
        /// <param name="identityIds">
        /// The ids of the identities associated with this agent.
        /// </param>
        /// <param name="messageBufferAutoclear">
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableSleeptime">
        /// If set to True, memory management will move to a background agent thread.
        /// </param>
        /// <param name="timezone">
        /// The timezone of the agent (IANA format).
        /// </param>
        /// <param name="maxFilesOpen">
        /// Maximum number of files that can be open at once for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </param>
        /// <param name="perFileViewWindowCharLimit">
        /// The per-file view window character limit for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="entityId">
        /// The id of the entity within the template.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> CreateInternalTemplateAgentAsync(
            string templateId,
            string baseTemplateId,
            string deploymentId,
            string entityId,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.CreateBlock>? memoryBlocks = default,
            global::System.Collections.Generic.IList<string>? tools = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            global::System.Collections.Generic.IList<string>? folderIds = default,
            global::System.Collections.Generic.IList<string>? blockIds = default,
            global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item3>? toolRules = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? system = default,
            global::G.AgentType? agentType = default,
            global::System.Collections.Generic.IList<global::G.MessageCreate>? initialMessageSequence = default,
            bool? includeBaseTools = default,
            bool? includeMultiAgentTools = default,
            bool? includeBaseToolRules = default,
            string? description = default,
            object? metadata = default,
            string? model = default,
            string? embedding = default,
            global::G.ModelSettingsVariant17? modelSettings = default,
            global::G.CompactionSettingsInput? compactionSettings = default,
            int? contextWindowLimit = default,
            global::System.Collections.Generic.Dictionary<string, string>? secrets = default,
            global::System.Collections.Generic.IList<string>? identityIds = default,
            bool? messageBufferAutoclear = default,
            bool? enableSleeptime = default,
            string? timezone = default,
            int? maxFilesOpen = default,
            int? perFileViewWindowCharLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
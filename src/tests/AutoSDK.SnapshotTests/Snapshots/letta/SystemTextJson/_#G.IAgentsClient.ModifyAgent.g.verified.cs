//HintName: G.IAgentsClient.ModifyAgent.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Modify Agent<br/>
        /// Update an existing agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> ModifyAgentAsync(
            string agentId,

            global::G.UpdateAgent request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Agent<br/>
        /// Update an existing agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="name">
        /// The name of the agent.
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
        /// <param name="tags">
        /// The tags associated with the agent.
        /// </param>
        /// <param name="system">
        /// The system prompt used by the agent.
        /// </param>
        /// <param name="toolRules">
        /// The tool rules governing the agent.
        /// </param>
        /// <param name="messageIds">
        /// The ids of the messages in the agent's in-context memory.
        /// </param>
        /// <param name="description">
        /// The description of the agent.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the agent.
        /// </param>
        /// <param name="toolExecEnvironmentVariables">
        /// Deprecated: use `secrets` field instead
        /// </param>
        /// <param name="secrets">
        /// The environment variables for tool execution specific to this agent.
        /// </param>
        /// <param name="projectId">
        /// The id of the project the agent belongs to.
        /// </param>
        /// <param name="templateId">
        /// The id of the template the agent belongs to.
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template id of the agent.
        /// </param>
        /// <param name="identityIds">
        /// The ids of the identities associated with this agent.
        /// </param>
        /// <param name="messageBufferAutoclear">
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.
        /// </param>
        /// <param name="model">
        /// The model handle used by the agent (format: provider/model-name).
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
        /// <param name="embeddingConfig">
        /// The embedding configuration used by the agent.
        /// </param>
        /// <param name="enableSleeptime">
        /// If set to True, memory management will move to a background agent thread.
        /// </param>
        /// <param name="lastRunCompletion">
        /// The timestamp when the agent last completed a run.
        /// </param>
        /// <param name="lastRunDurationMs">
        /// The duration in milliseconds of the agent's last run.
        /// </param>
        /// <param name="lastStopReason">
        /// The stop reason from the agent's last run.
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
        /// <param name="hidden">
        /// If set to True, the agent will be hidden.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> ModifyAgentAsync(
            string agentId,
            string? name = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            global::System.Collections.Generic.IList<string>? folderIds = default,
            global::System.Collections.Generic.IList<string>? blockIds = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? system = default,
            global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item4>? toolRules = default,
            global::System.Collections.Generic.IList<string>? messageIds = default,
            string? description = default,
            object? metadata = default,
            global::System.Collections.Generic.Dictionary<string, string>? toolExecEnvironmentVariables = default,
            global::System.Collections.Generic.Dictionary<string, string>? secrets = default,
            string? projectId = default,
            string? templateId = default,
            string? baseTemplateId = default,
            global::System.Collections.Generic.IList<string>? identityIds = default,
            bool? messageBufferAutoclear = default,
            string? model = default,
            string? embedding = default,
            global::G.ModelSettingsVariant18? modelSettings = default,
            global::G.CompactionSettingsInput? compactionSettings = default,
            int? contextWindowLimit = default,
            global::G.EmbeddingConfig? embeddingConfig = default,
            bool? enableSleeptime = default,
            global::System.DateTime? lastRunCompletion = default,
            int? lastRunDurationMs = default,
            global::G.StopReasonType? lastStopReason = default,
            string? timezone = default,
            int? maxFilesOpen = default,
            int? perFileViewWindowCharLimit = default,
            bool? hidden = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IAgentsClient.ExportAgent.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Export Agent<br/>
        /// Export the serialized JSON representation of an agent, formatted with indentation.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="maxSteps">
        /// Default Value: 100
        /// </param>
        /// <param name="useLegacyFormat">
        /// If True, exports using the legacy single-agent 'v1' format with inline tools/blocks. If False, exports using the new multi-entity 'v2' format, with separate agents, tools, blocks, files, etc.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to export. If provided, uses messages from this conversation instead of the agent's global message history.
        /// </param>
        /// <param name="scrubMessages">
        /// If True, excludes all messages from the export. Useful for sharing agent configs without conversation history.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExportAgentAsync(
            string agentId,

            global::G.BodyExportAgent request,
            int? maxSteps = default,
            bool? useLegacyFormat = default,
            string? conversationId = default,
            bool? scrubMessages = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Agent<br/>
        /// Export the serialized JSON representation of an agent, formatted with indentation.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="maxSteps">
        /// Default Value: 100
        /// </param>
        /// <param name="useLegacyFormat">
        /// If True, exports using the legacy single-agent 'v1' format with inline tools/blocks. If False, exports using the new multi-entity 'v2' format, with separate agents, tools, blocks, files, etc.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to export. If provided, uses messages from this conversation instead of the agent's global message history.
        /// </param>
        /// <param name="scrubMessages">
        /// If True, excludes all messages from the export. Useful for sharing agent configs without conversation history.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="spec"></param>
        /// <param name="legacySpec"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportAgentAsync(
            string agentId,
            int? maxSteps = default,
            bool? useLegacyFormat = default,
            string? conversationId = default,
            bool? scrubMessages = default,
            global::G.AgentFileSchema? spec = default,
            global::G.LettaSerializeSchemasPydanticAgentSchemaAgentSchema? legacySpec = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IAgentsClient.ImportAgent.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Import Agent<br/>
        /// Import a serialized agent file and recreate the agent(s) in the system.<br/>
        /// Returns the IDs of all imported agents.
        /// </summary>
        /// <param name="xOverrideEmbeddingModel"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImportedAgentsResponse> ImportAgentAsync(

            global::G.BodyImportAgent request,
            string? xOverrideEmbeddingModel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Agent<br/>
        /// Import a serialized agent file and recreate the agent(s) in the system.<br/>
        /// Returns the IDs of all imported agents.
        /// </summary>
        /// <param name="xOverrideEmbeddingModel"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="overrideExistingTools">
        /// If set to True, existing tools can get their source code overwritten by the uploaded tool definitions. Note that Letta core tools can never be updated externally.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stripMessages">
        /// If set to True, strips all messages from the agent before importing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="secrets">
        /// Secrets as a JSON string to pass to the agent for tool execution.
        /// </param>
        /// <param name="name">
        /// If provided, overrides the agent name with this value.
        /// </param>
        /// <param name="embedding">
        /// Embedding handle to override with.
        /// </param>
        /// <param name="model">
        /// Model handle to override the agent's default model. This allows the imported agent to use a different model while keeping other defaults (e.g., context size) from the original configuration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImportedAgentsResponse> ImportAgentAsync(
            byte[] file,
            string filename,
            string? xOverrideEmbeddingModel = default,
            bool? overrideExistingTools = default,
            bool? stripMessages = default,
            string? secrets = default,
            string? name = default,
            string? embedding = default,
            string? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
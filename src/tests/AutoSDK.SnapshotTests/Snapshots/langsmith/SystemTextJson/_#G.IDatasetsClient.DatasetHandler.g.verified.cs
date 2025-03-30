//HintName: G.IDatasetsClient.DatasetHandler.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DatasetHandlerAsync(
            global::G.PlaygroundRunOverDatasetRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Dataset Handler
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="secrets"></param>
        /// <param name="runId"></param>
        /// <param name="repoId"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="options">
        /// Configuration for a Runnable.
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="repoHandle"></param>
        /// <param name="owner"></param>
        /// <param name="commit"></param>
        /// <param name="evaluatorRules"></param>
        /// <param name="requestsPerSecond"></param>
        /// <param name="useWorkspaceSecrets">
        /// Default Value: false
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="datasetSplits"></param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DatasetHandlerAsync(
            object manifest,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::G.RunnableConfig options,
            string projectName,
            global::System.Guid datasetId,
            string? runId = default,
            string? repoId = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            string? toolChoice = default,
            bool? parallelToolCalls = default,
            string? repoHandle = default,
            string? owner = default,
            string? commit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? evaluatorRules = default,
            int? requestsPerSecond = default,
            bool? useWorkspaceSecrets = default,
            global::System.Collections.Generic.IList<string>? datasetSplits = default,
            int? repetitions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
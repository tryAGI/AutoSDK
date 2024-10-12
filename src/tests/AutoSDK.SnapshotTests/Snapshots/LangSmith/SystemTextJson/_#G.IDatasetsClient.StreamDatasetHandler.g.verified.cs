//HintName: G.IDatasetsClient.StreamDatasetHandler.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Stream Dataset Handler
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StreamDatasetHandlerApiV1DatasetsPlaygroundExperimentStreamPostResponse> StreamDatasetHandlerAsync(
            global::G.PlaygroundRunOverDatasetRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stream Dataset Handler
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="secrets"></param>
        /// <param name="runId"></param>
        /// <param name="repoId"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="options">
        /// Configuration for a Runnable.
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="datasetId"></param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StreamDatasetHandlerApiV1DatasetsPlaygroundExperimentStreamPostResponse> StreamDatasetHandlerAsync(
            global::G.PlaygroundRunOverDatasetRequestSchemaManifest manifest,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::G.RunnableConfig options,
            global::System.Guid datasetId,
            global::G.AnyOf<string, object>? runId = default,
            global::G.AnyOf<string, object>? repoId = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PlaygroundRunOverDatasetRequestSchemaToolsVariant1Item>, object>? tools = default,
            global::G.AnyOf<string, object>? toolChoice = default,
            global::G.AnyOf<string, object>? projectName = default,
            int? repetitions = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
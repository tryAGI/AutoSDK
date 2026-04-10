//HintName: G.IPipelinesClient.UpsertPipelineApiV1PipelinesPut.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Upsert Pipeline<br/>
        /// Upsert a pipeline.<br/>
        /// Updates the pipeline if one with the same name and project<br/>
        /// already exists, otherwise creates a new one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> UpsertPipelineApiV1PipelinesPutAsync(

            global::G.PipelineCreate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Pipeline<br/>
        /// Upsert a pipeline.<br/>
        /// Updates the pipeline if one with the same name and project<br/>
        /// already exists, otherwise creates a new one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="embeddingConfig"></param>
        /// <param name="transformConfig">
        /// Configuration for the transformation.
        /// </param>
        /// <param name="sparseModelConfig">
        /// Configuration for the sparse model used in hybrid search.
        /// </param>
        /// <param name="dataSinkId">
        /// Data sink ID. When provided instead of data_sink, the data sink will be looked up by ID.
        /// </param>
        /// <param name="embeddingModelConfigId">
        /// Embedding model config ID. When provided instead of embedding_config, the embedding model config will be looked up by ID.
        /// </param>
        /// <param name="dataSink">
        /// Data sink. When provided instead of data_sink_id, the data sink will be created.
        /// </param>
        /// <param name="presetRetrievalParameters">
        /// Preset retrieval parameters for the pipeline.
        /// </param>
        /// <param name="llamaParseParameters">
        /// Settings that can be configured for how to use LlamaParse to parse files within a LlamaCloud pipeline.
        /// </param>
        /// <param name="status">
        /// Status of the pipeline deployment.
        /// </param>
        /// <param name="metadataConfig">
        /// Metadata configuration for the pipeline.
        /// </param>
        /// <param name="name"></param>
        /// <param name="pipelineType">
        /// Type of pipeline. Either PLAYGROUND or MANAGED.<br/>
        /// Default Value: MANAGED
        /// </param>
        /// <param name="managedPipelineId">
        /// The ID of the ManagedPipeline this playground pipeline is linked to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> UpsertPipelineApiV1PipelinesPutAsync(
            string name,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.EmbeddingConfigVariant12? embeddingConfig = default,
            global::G.AnyOf<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig, object>? transformConfig = default,
            global::G.SparseModelConfig? sparseModelConfig = default,
            global::System.Guid? dataSinkId = default,
            global::System.Guid? embeddingModelConfigId = default,
            global::G.DataSinkCreate? dataSink = default,
            global::G.PresetRetrievalParams? presetRetrievalParameters = default,
            global::G.LlamaParseParameters? llamaParseParameters = default,
            string? status = default,
            global::G.PipelineMetadataConfig2? metadataConfig = default,
            global::G.PipelineType? pipelineType = default,
            global::System.Guid? managedPipelineId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
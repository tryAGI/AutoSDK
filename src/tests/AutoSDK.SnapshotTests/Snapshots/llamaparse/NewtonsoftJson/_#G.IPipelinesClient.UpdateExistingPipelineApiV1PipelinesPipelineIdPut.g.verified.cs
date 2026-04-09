//HintName: G.IPipelinesClient.UpdateExistingPipelineApiV1PipelinesPipelineIdPut.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Update Existing Pipeline<br/>
        /// Update an existing pipeline's configuration.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> UpdateExistingPipelineApiV1PipelinesPipelineIdPutAsync(
            global::System.Guid pipelineId,

            global::G.PipelineUpdate request,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Existing Pipeline<br/>
        /// Update an existing pipeline's configuration.
        /// </summary>
        /// <param name="pipelineId"></param>
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
        /// <param name="status">
        /// Status of the pipeline deployment.
        /// </param>
        /// <param name="metadataConfig">
        /// Metadata configuration for the pipeline.
        /// </param>
        /// <param name="name"></param>
        /// <param name="managedPipelineId">
        /// The ID of the ManagedPipeline this playground pipeline is linked to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> UpdateExistingPipelineApiV1PipelinesPipelineIdPutAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::G.EmbeddingConfigVariant13? embeddingConfig = default,
            global::G.AnyOf<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig, object>? transformConfig = default,
            global::G.SparseModelConfig? sparseModelConfig = default,
            global::System.Guid? dataSinkId = default,
            global::System.Guid? embeddingModelConfigId = default,
            global::G.DataSinkCreate? dataSink = default,
            global::G.PresetRetrievalParams? presetRetrievalParameters = default,
            string? status = default,
            global::G.PipelineMetadataConfig2? metadataConfig = default,
            string? name = default,
            global::System.Guid? managedPipelineId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
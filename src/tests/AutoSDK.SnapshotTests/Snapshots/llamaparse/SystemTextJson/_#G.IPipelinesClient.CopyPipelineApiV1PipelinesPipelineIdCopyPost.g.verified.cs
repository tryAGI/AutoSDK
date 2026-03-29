//HintName: G.IPipelinesClient.CopyPipelineApiV1PipelinesPipelineIdCopyPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Copy Pipeline<br/>
        /// Copy a pipeline including its files and documents.<br/>
        /// Creates a new pipeline with the same configuration and<br/>
        /// triggers a sync to populate the new vector store.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> CopyPipelineApiV1PipelinesPipelineIdCopyPostAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IPipelinesClient.DeletePipelineApiV1PipelinesPipelineIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Delete Pipeline<br/>
        /// Delete a pipeline and all associated resources.<br/>
        /// Removes pipeline files, data sources, and vector store data.<br/>
        /// This operation is irreversible.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePipelineApiV1PipelinesPipelineIdDeleteAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
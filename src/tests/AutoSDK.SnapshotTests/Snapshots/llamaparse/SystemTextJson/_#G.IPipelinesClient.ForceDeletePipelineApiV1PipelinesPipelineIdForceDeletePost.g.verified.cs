//HintName: G.IPipelinesClient.ForceDeletePipelineApiV1PipelinesPipelineIdForceDeletePost.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Force Delete Pipeline
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ForceDeletePipelineApiV1PipelinesPipelineIdForceDeletePostAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
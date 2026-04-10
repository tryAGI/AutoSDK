//HintName: G.IPipelinesClient.PipelinesUpdatePipeline.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Update Pipeline<br/>
        /// Update pipeline name or disable/enable it
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesUpdatePipelineResponse> PipelinesUpdatePipelineAsync(
            string pipelineId,

            global::G.PipelinesUpdatePipelineRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pipeline<br/>
        /// Update pipeline name or disable/enable it
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="name"></param>
        /// <param name="disabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesUpdatePipelineResponse> PipelinesUpdatePipelineAsync(
            string pipelineId,
            string? name = default,
            bool? disabled = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IAgentsClient.PreviewModelRequest.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Preview Model Request<br/>
        /// Inspect the raw LLM request payload without sending it.<br/>
        /// This endpoint processes the message through the agent loop up until<br/>
        /// the LLM request, then returns the raw request payload that would<br/>
        /// be sent to the LLM provider. Useful for debugging and inspection.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PreviewModelRequestAsync(
            string agentId,

            global::G.AnyOf<global::G.LettaRequest, global::G.LettaStreamingRequest> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Model Request<br/>
        /// Inspect the raw LLM request payload without sending it.<br/>
        /// This endpoint processes the message through the agent loop up until<br/>
        /// the LLM request, then returns the raw request payload that would<br/>
        /// be sent to the LLM provider. Useful for debugging and inspection.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PreviewModelRequestAsync(
            string agentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IPrompt2025Client.GetPrompt2025.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025String> GetPrompt2025Async(
            string promptId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
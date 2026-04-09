//HintName: G.IPromptClient.GetInputs.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptInputRecordArrayString> GetInputsAsync(
            string promptVersionId,

            global::G.GetInputsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="random"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptInputRecordArrayString> GetInputsAsync(
            string promptVersionId,
            double limit,
            bool? random = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
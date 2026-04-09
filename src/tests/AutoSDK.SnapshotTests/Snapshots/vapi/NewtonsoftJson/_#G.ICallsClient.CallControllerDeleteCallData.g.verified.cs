//HintName: G.ICallsClient.CallControllerDeleteCallData.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Delete Call
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Call> CallControllerDeleteCallDataAsync(
            string id,

            global::G.DeleteCallDTO request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Call
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids">
        /// These are the Call IDs to be bulk deleted.<br/>
        /// If provided, the call ID if any in the request query will be ignored<br/>
        /// When requesting a bulk delete, updates when a call is deleted will be sent as a webhook to the server URL configured in the Org settings.<br/>
        /// It may take up to a few hours to complete the bulk delete, and will be asynchronous.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Call> CallControllerDeleteCallDataAsync(
            string id,
            global::System.Collections.Generic.IList<string>? ids = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
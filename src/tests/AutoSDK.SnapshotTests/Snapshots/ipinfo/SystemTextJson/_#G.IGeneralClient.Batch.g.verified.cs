//HintName: G.IGeneralClient.Batch.g.cs
#nullable enable

namespace G
{
    public partial interface IGeneralClient
    {
        /// <summary>
        /// Returns information about the selected values.<br/>
        /// Returns information about the selected values.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, object>> BatchAsync(

            global::System.Collections.Generic.IList<string> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
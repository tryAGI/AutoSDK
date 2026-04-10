//HintName: G.ILabelsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Get label link<br/>
        /// Get label links for a specific project configuration. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LabelLink> GetAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
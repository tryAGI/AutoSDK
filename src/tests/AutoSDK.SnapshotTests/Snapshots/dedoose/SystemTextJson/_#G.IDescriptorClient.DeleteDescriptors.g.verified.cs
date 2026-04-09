//HintName: G.IDescriptorClient.DeleteDescriptors.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// DeleteDescriptors<br/>
        /// DeleteDescriptors
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDescriptorsAsync(

            global::G.DeleteDescriptorsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// DeleteDescriptors<br/>
        /// DeleteDescriptors
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="descriptorsIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDescriptorsAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> descriptorsIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IDescriptorClient.ForceDeleteDescriptorSetPolled.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// ForceDeleteDescriptorSetPolled<br/>
        /// ForceDeleteDescriptorSetPolled
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ForceDeleteDescriptorSetPolledAsync(

            global::G.ForceDeleteDescriptorSetPolledRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ForceDeleteDescriptorSetPolled<br/>
        /// ForceDeleteDescriptorSetPolled
        /// </summary>
        /// <param name="projectIDL"></param>
        /// <param name="descriptorSetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ForceDeleteDescriptorSetPolledAsync(
            global::System.Guid projectIDL,
            global::System.Guid descriptorSetId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
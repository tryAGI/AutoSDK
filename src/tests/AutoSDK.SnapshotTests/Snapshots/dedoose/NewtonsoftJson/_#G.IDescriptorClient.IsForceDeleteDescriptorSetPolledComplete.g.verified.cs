//HintName: G.IDescriptorClient.IsForceDeleteDescriptorSetPolledComplete.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// IsForceDeleteDescriptorSetPolledComplete<br/>
        /// IsForceDeleteDescriptorSetPolledComplete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> IsForceDeleteDescriptorSetPolledCompleteAsync(
            global::G.IsForceDeleteDescriptorSetPolledCompleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// IsForceDeleteDescriptorSetPolledComplete<br/>
        /// IsForceDeleteDescriptorSetPolledComplete
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> IsForceDeleteDescriptorSetPolledCompleteAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
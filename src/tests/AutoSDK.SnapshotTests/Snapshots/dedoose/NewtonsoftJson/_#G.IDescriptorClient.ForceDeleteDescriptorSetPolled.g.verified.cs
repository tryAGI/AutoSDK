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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ForceDeleteDescriptorSetPolledAsync(
            global::G.ForceDeleteDescriptorSetPolledRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ForceDeleteDescriptorSetPolled<br/>
        /// ForceDeleteDescriptorSetPolled
        /// </summary>
        /// <param name="projectIDL"></param>
        /// <param name="descriptorSetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ForceDeleteDescriptorSetPolledAsync(
            global::System.Guid projectIDL,
            global::System.Guid descriptorSetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
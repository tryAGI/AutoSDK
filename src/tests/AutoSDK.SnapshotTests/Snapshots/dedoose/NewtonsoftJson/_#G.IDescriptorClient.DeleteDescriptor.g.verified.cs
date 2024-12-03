//HintName: G.IDescriptorClient.DeleteDescriptor.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// DeleteDescriptor<br/>
        /// DeleteDescriptor
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Descriptor> DeleteDescriptorAsync(
            global::G.DeleteDescriptorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteDescriptor<br/>
        /// DeleteDescriptor
        /// </summary>
        /// <param name="descriptor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Descriptor> DeleteDescriptorAsync(
            global::G.Descriptor descriptor,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IDescriptorClient.UpdateDescriptorSet.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// UpdateDescriptorSet<br/>
        /// UpdateDescriptorSet
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorSet> UpdateDescriptorSetAsync(
            global::G.UpdateDescriptorSetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateDescriptorSet<br/>
        /// UpdateDescriptorSet
        /// </summary>
        /// <param name="set"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorSet> UpdateDescriptorSetAsync(
            global::G.DescriptorSet set,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
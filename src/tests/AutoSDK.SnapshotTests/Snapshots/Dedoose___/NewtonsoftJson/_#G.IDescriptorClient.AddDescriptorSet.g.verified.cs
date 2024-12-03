//HintName: G.IDescriptorClient.AddDescriptorSet.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDescriptorSet<br/>
        /// AddDescriptorSet
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorSet> AddDescriptorSetAsync(
            global::G.AddDescriptorSetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddDescriptorSet<br/>
        /// AddDescriptorSet
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createByUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorSet> AddDescriptorSetAsync(
            global::System.Guid projectId,
            string title,
            string description,
            global::System.Guid createByUserId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
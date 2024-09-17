//HintName: G.IDescriptorClient.DescriptorAddDescriptorSet.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDescriptorSet.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createByUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorSet> DescriptorAddDescriptorSetAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? title = default,
            string? description = default,
            global::System.Guid? createByUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
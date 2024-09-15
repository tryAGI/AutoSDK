//HintName: G.IDescriptorClient.DescriptorGetResourceLinks.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetResourceLinks.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorGetResourceLinksResponse> DescriptorGetResourceLinksAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid resourceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
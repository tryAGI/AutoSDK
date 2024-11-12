//HintName: G.IResourceClient.ResourceGetVideoResourceByJobId.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetVideoResourceByJobId.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> ResourceGetVideoResourceByJobIdAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? jobId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
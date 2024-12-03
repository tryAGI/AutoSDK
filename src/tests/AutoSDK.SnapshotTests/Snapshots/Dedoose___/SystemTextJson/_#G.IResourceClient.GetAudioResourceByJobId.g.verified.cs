//HintName: G.IResourceClient.GetAudioResourceByJobId.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetAudioResourceByJobId<br/>
        /// GetAudioResourceByJobId
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> GetAudioResourceByJobIdAsync(
            global::G.GetAudioResourceByJobIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetAudioResourceByJobId<br/>
        /// GetAudioResourceByJobId
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Resource> GetAudioResourceByJobIdAsync(
            global::System.Guid projectId,
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
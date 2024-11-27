//HintName: G.IResourceClient.GetAudioSample.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetAudioSample<br/>
        /// GetAudioSample
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAudioSampleAsync(
            global::G.GetAudioSampleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetAudioSample<br/>
        /// GetAudioSample
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetAudioSampleAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
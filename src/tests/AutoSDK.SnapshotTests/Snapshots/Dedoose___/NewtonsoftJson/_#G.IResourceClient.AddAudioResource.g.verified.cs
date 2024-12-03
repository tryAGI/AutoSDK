//HintName: G.IResourceClient.AddAudioResource.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// AddAudioResource<br/>
        /// AddAudioResource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddAudioResourceAsync(
            global::G.AddAudioResourceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddAudioResource<br/>
        /// AddAudioResource
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="videoUploadURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddAudioResourceAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            string title,
            string description,
            string videoUploadURL,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
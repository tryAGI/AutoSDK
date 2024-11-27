//HintName: G.ITagClient.RemoveTagApplication.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// RemoveTagApplication<br/>
        /// RemoveTagApplication
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagAppDTO> RemoveTagApplicationAsync(
            global::G.RemoveTagApplicationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// RemoveTagApplication<br/>
        /// RemoveTagApplication
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tagAppId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagAppDTO> RemoveTagApplicationAsync(
            global::System.Guid projectId,
            global::System.Guid tagAppId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IFilesClient.FileContentFileContentPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// File Content
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> FileContentFileContentPostAsync(

            global::G.FileContentReadReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// File Content
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="digest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> FileContentFileContentPostAsync(
            string projectId,
            string digest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IFilesClient.FileControllerCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> FileControllerCreateAsync(

            global::G.CreateFileDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="file">
        /// This is the File you want to upload for use with the Knowledge Base.
        /// </param>
        /// <param name="filename">
        /// This is the File you want to upload for use with the Knowledge Base.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> FileControllerCreateAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
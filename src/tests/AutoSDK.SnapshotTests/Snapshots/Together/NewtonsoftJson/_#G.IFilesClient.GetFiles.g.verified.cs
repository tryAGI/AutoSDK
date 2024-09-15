//HintName: G.IFilesClient.GetFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List all files<br/>
        /// List the metadata for all uploaded data files.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileList> GetFilesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
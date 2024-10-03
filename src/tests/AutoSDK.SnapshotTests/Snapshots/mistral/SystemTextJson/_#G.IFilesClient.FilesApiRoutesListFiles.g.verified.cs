//HintName: G.IFilesClient.FilesApiRoutesListFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files<br/>
        /// Returns a list of files that belong to the user's organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFilesOut> FilesApiRoutesListFilesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
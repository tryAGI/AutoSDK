//HintName: G.IStorageLocalClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageLocalClient
    {
        /// <summary>
        /// Get all export storage<br/>
        /// Get a list of all local file export storage connections.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LocalFilesExportStorage>> ListAsync(
            int project,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
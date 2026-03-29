//HintName: G.IStorageGcsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageGcsClient
    {
        /// <summary>
        /// Get all export storage<br/>
        /// Get a list of all GCS export storage connections.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GCSExportStorage>> ListAsync(
            int project,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
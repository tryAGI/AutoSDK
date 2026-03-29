//HintName: G.IArchivesClient.DeleteArchive.g.cs
#nullable enable

namespace G
{
    public partial interface IArchivesClient
    {
        /// <summary>
        /// Delete Archive<br/>
        /// Delete an archive by its ID.
        /// </summary>
        /// <param name="archiveId">
        /// The ID of the archive in the format 'archive-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteArchiveAsync(
            string archiveId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
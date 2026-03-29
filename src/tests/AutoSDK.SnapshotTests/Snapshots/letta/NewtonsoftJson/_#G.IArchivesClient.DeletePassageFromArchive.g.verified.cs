//HintName: G.IArchivesClient.DeletePassageFromArchive.g.cs
#nullable enable

namespace G
{
    public partial interface IArchivesClient
    {
        /// <summary>
        /// Delete Passage From Archive<br/>
        /// Delete a passage from an archive.<br/>
        /// This permanently removes the passage from both the database and vector storage (if applicable).
        /// </summary>
        /// <param name="archiveId">
        /// The ID of the archive in the format 'archive-&lt;uuid4&gt;'
        /// </param>
        /// <param name="passageId">
        /// The ID of the passage in the format 'passage-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePassageFromArchiveAsync(
            string archiveId,
            string passageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
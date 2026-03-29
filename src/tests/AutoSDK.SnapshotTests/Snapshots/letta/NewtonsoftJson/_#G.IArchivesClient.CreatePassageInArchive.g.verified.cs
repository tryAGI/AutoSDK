//HintName: G.IArchivesClient.CreatePassageInArchive.g.cs
#nullable enable

namespace G
{
    public partial interface IArchivesClient
    {
        /// <summary>
        /// Create Passage In Archive<br/>
        /// Create a new passage in an archive.<br/>
        /// This adds a passage to the archive and creates embeddings for vector storage.
        /// </summary>
        /// <param name="archiveId">
        /// The ID of the archive in the format 'archive-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Passage> CreatePassageInArchiveAsync(
            string archiveId,

            global::G.PassageCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Passage In Archive<br/>
        /// Create a new passage in an archive.<br/>
        /// This adds a passage to the archive and creates embeddings for vector storage.
        /// </summary>
        /// <param name="archiveId">
        /// The ID of the archive in the format 'archive-&lt;uuid4&gt;'
        /// </param>
        /// <param name="text">
        /// The text content of the passage
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the passage
        /// </param>
        /// <param name="tags">
        /// Optional tags for categorizing the passage
        /// </param>
        /// <param name="createdAt">
        /// Optional creation datetime for the passage (ISO 8601 format)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Passage> CreatePassageInArchiveAsync(
            string archiveId,
            string text,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? createdAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
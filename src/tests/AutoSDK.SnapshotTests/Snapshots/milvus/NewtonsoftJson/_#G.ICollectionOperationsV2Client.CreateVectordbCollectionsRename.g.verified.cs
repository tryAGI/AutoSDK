//HintName: G.ICollectionOperationsV2Client.CreateVectordbCollectionsRename.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionOperationsV2Client
    {
        /// <summary>
        /// Rename Collection<br/>
        /// This operation renames an existing collection and optionally moves the collection to a new database.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbCollectionsRenameAsync(

            global::G.CreateVectordbCollectionsRenameRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename Collection<br/>
        /// This operation renames an existing collection and optionally moves the collection to a new database.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="newDbName">
        /// The name of the database to which the collection belongs after this operation.<br/>
        /// The value defaults to **default**. Setting this to a database rather than the one the collection belongs to before this operation moves this collection to the specified database.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="newCollectionName">
        /// The name of the target collection after this operation.<br/>
        /// Setting this to the value of **old_collection_name** results in a **MilvusException**.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbCollectionsRenameAsync(
            string collectionName,
            string newCollectionName,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            string? newDbName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
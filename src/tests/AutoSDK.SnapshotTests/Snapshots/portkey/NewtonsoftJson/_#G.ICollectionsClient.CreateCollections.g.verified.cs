//HintName: G.ICollectionsClient.CreateCollections.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Create a new collection<br/>
        /// Creates a new collection in the specified workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCollectionsResponse> CreateCollectionsAsync(

            global::G.CreateCollectionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new collection<br/>
        /// Creates a new collection in the specified workspace
        /// </summary>
        /// <param name="workspaceId">
        /// ID or slug of the workspace
        /// </param>
        /// <param name="name">
        /// Name of the collection
        /// </param>
        /// <param name="parentCollectionId">
        /// ID or slug of the parent collection (optional)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCollectionsResponse> CreateCollectionsAsync(
            string name,
            string? workspaceId = default,
            string? parentCollectionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
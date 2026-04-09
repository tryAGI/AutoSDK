//HintName: G.ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// Retrieve an entity<br/>
        /// This method retrieves details about the specified entity.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> RetrieveAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
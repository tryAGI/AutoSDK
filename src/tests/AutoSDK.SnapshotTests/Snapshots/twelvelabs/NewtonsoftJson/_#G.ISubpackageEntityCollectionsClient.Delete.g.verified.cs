//HintName: G.ISubpackageEntityCollectionsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsClient
    {
        /// <summary>
        /// Delete an entity collection<br/>
        /// This method deletes the specified entity collection. This action cannot be undone.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EntityCollectionsDeleteResponse204> DeleteAsync(
            string entityCollectionId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
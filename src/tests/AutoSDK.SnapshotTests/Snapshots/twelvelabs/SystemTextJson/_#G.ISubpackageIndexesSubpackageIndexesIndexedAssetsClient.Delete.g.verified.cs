//HintName: G.ISubpackageIndexesSubpackageIndexesIndexedAssetsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        /// <summary>
        /// Delete indexed asset information<br/>
        /// This method deletes all the information about the specified indexed asset. This action cannot be undone.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesIndexedAssetsDeleteResponse204> DeleteAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.ISubpackageAssetsClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageAssetsClient
    {
        /// <summary>
        /// Retrieve an asset<br/>
        /// This method retrieves details about the specified asset.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Asset> RetrieveAsync(
            string assetId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
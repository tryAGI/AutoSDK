//HintName: G.IMeshesClient.PurchaseMesh.g.cs
#nullable enable

namespace G
{
    public partial interface IMeshesClient
    {
        /// <summary>
        /// Purchase a mesh asset
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PurchaseMeshAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
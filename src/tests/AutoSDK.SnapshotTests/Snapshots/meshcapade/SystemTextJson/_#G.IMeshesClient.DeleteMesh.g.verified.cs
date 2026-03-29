//HintName: G.IMeshesClient.DeleteMesh.g.cs
#nullable enable

namespace G
{
    public partial interface IMeshesClient
    {
        /// <summary>
        /// Delete mesh
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteMeshAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
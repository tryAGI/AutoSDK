//HintName: G.IAssetsClient.V1AssetUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// v1/asset (upload)<br/>
        /// v1/asset (upload)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1AssetUploadAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
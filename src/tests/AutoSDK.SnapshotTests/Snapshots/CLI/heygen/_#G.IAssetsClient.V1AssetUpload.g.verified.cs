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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1AssetUploadAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.ISubpackageAssetsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageAssetsClient
    {
        /// <summary>
        /// List assets<br/>
        /// This method returns a list of assets in your account.<br/>
        /// The platform returns your assets sorted by creation date, with the newest at the top of the list.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="assetIds"></param>
        /// <param name="assetTypes"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetsListResponse200> ListAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::System.Collections.Generic.IList<string>? assetIds = default,
            global::System.Collections.Generic.IList<global::G.AssetsGetParametersAssetTypesSchemaItems>? assetTypes = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
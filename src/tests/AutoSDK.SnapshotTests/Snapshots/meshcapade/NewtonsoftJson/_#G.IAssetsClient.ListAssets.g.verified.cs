//HintName: G.IAssetsClient.ListAssets.g.cs
#nullable enable

namespace G
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// List assets (multi-type)
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="page"></param>
        /// <param name="include"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetListResponse> ListAssetsAsync(
            int? limit = default,
            int? page = default,
            string? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
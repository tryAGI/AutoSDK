//HintName: G.IApi.UploadAssetPublicAssetsIdUploadPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Upload Asset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Asset> UploadAssetPublicAssetsIdUploadPostAsync(
            global::System.Guid id,

            global::G.BodyUploadAssetPublicAssetsIdUploadPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Asset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="file"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Asset> UploadAssetPublicAssetsIdUploadPostAsync(
            global::System.Guid id,
            string file,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IApi.GenerateAssetPublicGenerationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Generate Asset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateAssetPublicGenerationsPostResponse> GenerateAssetPublicGenerationsPostAsync(

            global::G.GenerateAssetPublicGenerationsPostRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Asset
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateAssetPublicGenerationsPostResponse> GenerateAssetPublicGenerationsPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
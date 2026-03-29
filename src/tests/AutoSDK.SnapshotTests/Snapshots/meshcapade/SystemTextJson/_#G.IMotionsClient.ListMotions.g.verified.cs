//HintName: G.IMotionsClient.ListMotions.g.cs
#nullable enable

namespace G
{
    public partial interface IMotionsClient
    {
        /// <summary>
        /// List all motions
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetListResponse> ListMotionsAsync(
            int? limit = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
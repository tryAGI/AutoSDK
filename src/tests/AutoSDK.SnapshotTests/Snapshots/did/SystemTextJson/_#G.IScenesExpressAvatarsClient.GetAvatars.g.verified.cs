//HintName: G.IScenesExpressAvatarsClient.GetAvatars.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesExpressAvatarsClient
    {
        /// <summary>
        /// Get a list of the avatars
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAvatarsResponse> GetAvatarsAsync(
            double? limit = default,
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IScenesExpressAvatarsClient.Get1.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesExpressAvatarsClient
    {
        /// <summary>
        /// Get a specific scene
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Get1Response> Get1Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
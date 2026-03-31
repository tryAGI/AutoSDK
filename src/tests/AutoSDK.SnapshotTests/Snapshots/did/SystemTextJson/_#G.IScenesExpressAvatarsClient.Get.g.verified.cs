//HintName: G.IScenesExpressAvatarsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesExpressAvatarsClient
    {
        /// <summary>
        /// Get an avatar by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetResponse> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
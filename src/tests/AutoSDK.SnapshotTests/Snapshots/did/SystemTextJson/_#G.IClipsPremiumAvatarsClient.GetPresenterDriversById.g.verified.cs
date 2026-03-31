//HintName: G.IClipsPremiumAvatarsClient.GetPresenterDriversById.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Get presenter drivers by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPresenterDriversByIdResponse> GetPresenterDriversByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
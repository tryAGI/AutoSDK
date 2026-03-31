//HintName: G.IClipsPremiumAvatarsClient.GetClip.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Get a specific clip
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetClipResponse2> GetClipAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
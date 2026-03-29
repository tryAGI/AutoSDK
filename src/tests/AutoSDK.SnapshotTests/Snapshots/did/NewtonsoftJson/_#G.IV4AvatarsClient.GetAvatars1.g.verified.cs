//HintName: G.IV4AvatarsClient.GetAvatars1.g.cs
#nullable enable

namespace G
{
    public partial interface IV4AvatarsClient
    {
        /// <summary>
        /// List all of the expressive avatars
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAvatars1Response> GetAvatars1Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
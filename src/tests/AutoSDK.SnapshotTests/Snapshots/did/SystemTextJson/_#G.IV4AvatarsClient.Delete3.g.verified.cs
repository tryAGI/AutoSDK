//HintName: G.IV4AvatarsClient.Delete3.g.cs
#nullable enable

namespace G
{
    public partial interface IV4AvatarsClient
    {
        /// <summary>
        /// Delete Video by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete3Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
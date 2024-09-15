//HintName: G.IEmojisClient.EmojisGet.g.cs
#nullable enable

namespace G
{
    public partial interface IEmojisClient
    {
        /// <summary>
        /// Get emojis<br/>
        /// Lists all the emojis available to use on GitHub.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmojisGetResponse> EmojisGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
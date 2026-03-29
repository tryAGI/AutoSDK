//HintName: G.ITalksStandardAvatarsClient.GetTalk.g.cs
#nullable enable

namespace G
{
    public partial interface ITalksStandardAvatarsClient
    {
        /// <summary>
        /// Get a specific talk
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTalkResponse> GetTalkAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
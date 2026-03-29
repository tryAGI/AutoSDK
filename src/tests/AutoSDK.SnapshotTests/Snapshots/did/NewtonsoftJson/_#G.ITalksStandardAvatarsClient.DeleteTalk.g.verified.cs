//HintName: G.ITalksStandardAvatarsClient.DeleteTalk.g.cs
#nullable enable

namespace G
{
    public partial interface ITalksStandardAvatarsClient
    {
        /// <summary>
        /// Delete a specific talk
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteTalkResponse> DeleteTalkAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
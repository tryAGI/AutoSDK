//HintName: G.IChatsClient.GetChatAudio.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Get chat audio
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnChatAudioReconstruction> GetChatAudioAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
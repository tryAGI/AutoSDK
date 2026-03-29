//HintName: G.ILiveV2Client.StreamingControllerGetAudioV2.g.cs
#nullable enable

namespace G
{
    public partial interface ILiveV2Client
    {
        /// <summary>
        /// Download the audio file used for this live job
        /// </summary>
        /// <param name="id">
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamingControllerGetAudioV2Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
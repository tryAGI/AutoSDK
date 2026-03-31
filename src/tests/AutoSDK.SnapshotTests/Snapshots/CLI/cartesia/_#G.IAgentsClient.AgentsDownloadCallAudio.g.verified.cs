//HintName: G.IAgentsClient.AgentsDownloadCallAudio.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Download Call Audio<br/>
        /// The downloaded audio file is in .wav format. This endpoint streams the audio file content (WAV format) to the client.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AgentsDownloadCallAudioAsync(
            global::G.AgentsDownloadCallAudioCartesiaVersion cartesiaVersion,
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
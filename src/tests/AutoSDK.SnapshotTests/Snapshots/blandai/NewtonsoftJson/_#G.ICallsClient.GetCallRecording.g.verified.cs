//HintName: G.ICallsClient.GetCallRecording.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Get Call Recording<br/>
        /// Retrieve the audio recording for a completed call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="contentType">
        /// Default Value: audio/wav
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetCallRecordingAsync(
            string callId,
            global::G.GetCallRecordingContentType? contentType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
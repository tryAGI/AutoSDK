//HintName: G.ICallsClient.CallsRecordingRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Returns or redirects to a recording of the call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CallsRecordingRetrieveAsync(
            global::System.Guid callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
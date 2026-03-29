//HintName: G.ICallsClient.GetCallDetails.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call Details<br/>
        /// Retrieve detailed information, metadata, and transcripts for a specific call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CallDetails> GetCallDetailsAsync(
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
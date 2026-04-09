//HintName: G.ICallsClient.CallsStagesMessagesAudioRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callStageId"></param>
        /// <param name="callStageMessageIndex"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CallsStagesMessagesAudioRetrieveAsync(
            global::System.Guid callId,
            global::System.Guid callStageId,
            int callStageMessageIndex,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IBatchClient.StartBatchInferenceJob.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Start a batch inference job<br/>
        /// Submit media URLs or text for emotion analysis
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.JobId> StartBatchInferenceJobAsync(

            global::G.InferenceBaseRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a batch inference job<br/>
        /// Submit media URLs or text for emotion analysis
        /// </summary>
        /// <param name="models"></param>
        /// <param name="transcription"></param>
        /// <param name="urls"></param>
        /// <param name="text"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="notify"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.JobId> StartBatchInferenceJobAsync(
            global::G.ModelsConfig? models = default,
            global::G.TranscriptionConfig? transcription = default,
            global::System.Collections.Generic.IList<string>? urls = default,
            global::System.Collections.Generic.IList<string>? text = default,
            string? callbackUrl = default,
            bool? notify = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
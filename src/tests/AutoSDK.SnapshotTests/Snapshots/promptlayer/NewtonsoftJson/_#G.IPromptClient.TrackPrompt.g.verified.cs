//HintName: G.IPromptClient.TrackPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Track Prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrackPromptResponse> TrackPromptAsync(

            global::G.TrackPromptRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Track Prompt
        /// </summary>
        /// <param name="promptName">
        /// The name of the prompt template.
        /// </param>
        /// <param name="promptInputVariables">
        /// Input variables for the prompt template.
        /// </param>
        /// <param name="requestId">
        /// The unique identifier for the request.
        /// </param>
        /// <param name="version">
        /// The version of the prompt template. Both version and label cannot be specified. Only one or none.
        /// </param>
        /// <param name="label">
        /// The label of the prompt template version. Both version and label cannot be specified. Only one or none.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrackPromptResponse> TrackPromptAsync(
            string promptName,
            int requestId,
            global::System.Collections.Generic.Dictionary<string, string>? promptInputVariables = default,
            int? version = default,
            string? label = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
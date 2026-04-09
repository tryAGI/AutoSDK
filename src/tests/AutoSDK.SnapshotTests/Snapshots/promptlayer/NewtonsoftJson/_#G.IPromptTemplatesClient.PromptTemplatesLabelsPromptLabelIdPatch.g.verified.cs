//HintName: G.IPromptTemplatesClient.PromptTemplatesLabelsPromptLabelIdPatch.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Move Prompt Template Labels
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptTemplatesLabelsPromptLabelIdPatchResponse> PromptTemplatesLabelsPromptLabelIdPatchAsync(
            int promptLabelId,

            global::G.PromptTemplatesLabelsPromptLabelIdPatchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Prompt Template Labels
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="promptVersionNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptTemplatesLabelsPromptLabelIdPatchResponse> PromptTemplatesLabelsPromptLabelIdPatchAsync(
            int promptLabelId,
            int promptVersionNumber,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
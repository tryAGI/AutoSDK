//HintName: G.IPromptTemplatesClient.DeletePromptTemplatesLabelsPromptLabelId.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Delete Prompt Template Label
        /// </summary>
        /// <param name="promptLabelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePromptTemplatesLabelsPromptLabelIdAsync(
            int promptLabelId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
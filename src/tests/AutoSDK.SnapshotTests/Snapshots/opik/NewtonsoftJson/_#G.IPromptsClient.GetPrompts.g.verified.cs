//HintName: G.IPromptsClient.GetPrompts.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompts<br/>
        /// Get prompts
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter prompts by name (partial match, case insensitive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptPagePublic> GetPromptsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            global::System.Guid? projectId = default,
            string? sorting = default,
            string? filters = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
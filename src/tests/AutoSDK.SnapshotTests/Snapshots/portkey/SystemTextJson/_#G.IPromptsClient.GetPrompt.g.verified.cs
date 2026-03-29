//HintName: G.IPromptsClient.GetPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get a prompt by ID or slug
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Prompt2> GetPromptAsync(
            string promptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
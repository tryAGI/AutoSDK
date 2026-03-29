//HintName: G.IPromptsClient.DeserializePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Deserialize Prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptResponse> DeserializePromptAsync(

            global::G.DeserializePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deserialize Prompt
        /// </summary>
        /// <param name="content">
        /// Raw .prompt file content.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptResponse> DeserializePromptAsync(
            string content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
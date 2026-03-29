//HintName: G.IPromptsClient.CreatePromptVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create a prompt version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnPrompt> CreatePromptVersionAsync(
            string id,

            global::G.PostedPromptVersion request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a prompt version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionDescription"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnPrompt> CreatePromptVersionAsync(
            string id,
            string text,
            string? versionDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
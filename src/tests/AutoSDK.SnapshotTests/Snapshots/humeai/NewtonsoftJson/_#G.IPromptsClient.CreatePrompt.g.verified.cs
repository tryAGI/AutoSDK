//HintName: G.IPromptsClient.CreatePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create an EVI prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnPrompt> CreatePromptAsync(

            global::G.PostedPrompt request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an EVI prompt
        /// </summary>
        /// <param name="name"></param>
        /// <param name="versionDescription"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnPrompt> CreatePromptAsync(
            string name,
            string text,
            string? versionDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
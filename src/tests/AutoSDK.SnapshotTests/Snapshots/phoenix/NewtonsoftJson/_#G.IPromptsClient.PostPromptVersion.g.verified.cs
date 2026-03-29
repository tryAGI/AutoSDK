//HintName: G.IPromptsClient.PostPromptVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create a new prompt<br/>
        /// Create a new prompt and its initial version. A prompt can have multiple versions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptResponseBody> PostPromptVersionAsync(

            global::G.CreatePromptRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new prompt<br/>
        /// Create a new prompt and its initial version. A prompt can have multiple versions.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptResponseBody> PostPromptVersionAsync(
            global::G.PromptData prompt,
            global::G.PromptVersionData version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
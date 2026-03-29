//HintName: G.IPromptPartialsClient.CreatePromptPartial.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptPartialsClient
    {
        /// <summary>
        /// Create a new prompt partial
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptPartialResponse> CreatePromptPartialAsync(

            global::G.CreatePromptPartialRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new prompt partial
        /// </summary>
        /// <param name="workspaceId">
        /// Required for Admin keys
        /// </param>
        /// <param name="name"></param>
        /// <param name="string">
        /// Prompt partial template in string format
        /// </param>
        /// <param name="versionDescription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptPartialResponse> CreatePromptPartialAsync(
            string name,
            string @string,
            string? workspaceId = default,
            string? versionDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
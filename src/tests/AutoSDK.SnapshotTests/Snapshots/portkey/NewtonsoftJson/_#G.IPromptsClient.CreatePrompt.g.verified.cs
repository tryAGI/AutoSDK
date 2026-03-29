//HintName: G.IPromptsClient.CreatePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create a new prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptResponse> CreatePromptAsync(

            global::G.CreatePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new prompt
        /// </summary>
        /// <param name="name"></param>
        /// <param name="collectionId">
        /// UUID or slug of the collection
        /// </param>
        /// <param name="string">
        /// Prompt template in string format
        /// </param>
        /// <param name="parameters">
        /// Parameters for the prompt
        /// </param>
        /// <param name="functions">
        /// Functions for the prompt
        /// </param>
        /// <param name="tools">
        /// Tools for the prompt
        /// </param>
        /// <param name="toolChoice">
        /// Tool Choice for the prompt
        /// </param>
        /// <param name="model">
        /// The model to use for the prompt
        /// </param>
        /// <param name="virtualKey">
        /// The virtual key to use for the prompt
        /// </param>
        /// <param name="versionDescription">
        /// The description of the prompt version
        /// </param>
        /// <param name="templateMetadata">
        /// Metadata for the prompt
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptResponse> CreatePromptAsync(
            string name,
            string collectionId,
            string @string,
            object parameters,
            string virtualKey,
            global::System.Collections.Generic.IList<object>? functions = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            object? toolChoice = default,
            string? model = default,
            string? versionDescription = default,
            object? templateMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
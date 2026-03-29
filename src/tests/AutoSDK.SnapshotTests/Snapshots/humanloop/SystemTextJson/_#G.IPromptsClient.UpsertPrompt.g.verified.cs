//HintName: G.IPromptsClient.UpsertPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Upsert Prompt<br/>
        /// Create or update a Prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptResponse> UpsertPromptAsync(

            global::G.PromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Prompt<br/>
        /// Create or update a Prompt.
        /// </summary>
        /// <param name="path">
        /// Path of the Prompt, including the name.
        /// </param>
        /// <param name="id">
        /// ID for an existing Prompt.
        /// </param>
        /// <param name="model">
        /// The model instance used, e.g. gpt-4.
        /// </param>
        /// <param name="endpoint">
        /// The provider model endpoint used.
        /// </param>
        /// <param name="template">
        /// The template for the prompt.
        /// </param>
        /// <param name="provider">
        /// The company providing the underlying model service.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature.
        /// </param>
        /// <param name="topP"></param>
        /// <param name="stop"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="other"></param>
        /// <param name="seed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="tools"></param>
        /// <param name="linkedTools">
        /// IDs of Tools linked to this prompt.
        /// </param>
        /// <param name="attributes"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptResponse> UpsertPromptAsync(
            string model,
            string? path = default,
            string? id = default,
            string? endpoint = default,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? template = default,
            string? provider = default,
            int? maxTokens = default,
            double? temperature = default,
            double? topP = default,
            string? stop = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            object? other = default,
            int? seed = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Collections.Generic.IList<global::G.ToolFunction>? tools = default,
            global::System.Collections.Generic.IList<string>? linkedTools = default,
            object? attributes = default,
            string? versionName = default,
            string? versionDescription = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? readme = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
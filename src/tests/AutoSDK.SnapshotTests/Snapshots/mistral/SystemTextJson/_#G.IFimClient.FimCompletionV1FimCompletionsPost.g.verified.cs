//HintName: G.IFimClient.FimCompletionV1FimCompletionsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFimClient
    {
        /// <summary>
        /// Fim Completion<br/>
        /// FIM completion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FIMCompletionResponse> FimCompletionV1FimCompletionsPostAsync(
            global::G.FIMCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Fim Completion<br/>
        /// FIM completion.
        /// </summary>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </param>
        /// <param name="minTokens">
        /// The minimum number of tokens to generate in the completion.
        /// </param>
        /// <param name="model">
        /// ID of the model to use. Only compatible for now with:<br/>
        ///   - `codestral-2405`<br/>
        ///   - `codestral-latest`<br/>
        /// Default Value: codestral-2405<br/>
        /// Example: codestral-2405
        /// </param>
        /// <param name="prompt">
        /// The text/code to complete.<br/>
        /// Example: def
        /// </param>
        /// <param name="randomSeed">
        /// The seed to use for random sampling. If set, different calls will generate deterministic results.
        /// </param>
        /// <param name="stop">
        /// Stop generation if this token is detected. Or if one of these tokens is detected when providing an array
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-side events as they become available, with the stream terminated by a data: [DONE] message. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="suffix">
        /// Optional text/code that adds more context for the model. When given a `prompt` and a `suffix` the model will fill what is between them. When `suffix` is not provided, the model will simply execute completion starting with `prompt`.<br/>
        /// Example: return a+b
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, we recommend between 0.0 and 0.7. Higher values like 0.7 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or `top_p` but not both. The default value varies depending on the model you are targeting. Call the `/models` endpoint to retrieve the appropriate value.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling, where the model considers the results of the tokens with `top_p` probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FIMCompletionResponse> FimCompletionV1FimCompletionsPostAsync(
            string model,
            string prompt,
            int? maxTokens = default,
            int? minTokens = default,
            int? randomSeed = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            string? suffix = default,
            double? temperature = default,
            double? topP = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.IAgentsClient.AgentsCompletionV1AgentsCompletionsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Agents Completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> AgentsCompletionV1AgentsCompletionsPostAsync(
            global::G.AgentsCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Agents Completion
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent to use for this completion.
        /// </param>
        /// <param name="frequencyPenalty">
        /// frequency_penalty penalizes the repetition of words based on their frequency in the generated text. A higher frequency penalty discourages the model from repeating words that have already appeared frequently in the output, promoting diversity and reducing repetition.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </param>
        /// <param name="messages">
        /// The prompt(s) to generate completions for, encoded as a list of dict with role and content.<br/>
        /// Example: []
        /// </param>
        /// <param name="n">
        /// Number of completions to return for each request, input tokens are only billed once.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Default Value: true
        /// </param>
        /// <param name="prediction"></param>
        /// <param name="presencePenalty">
        /// presence_penalty determines how much the model penalizes the repetition of words or phrases. A higher presence penalty encourages the model to use a wider variety of words and phrases, making the output more diverse and creative.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="randomSeed">
        /// The seed to use for random sampling. If set, different calls will generate deterministic results.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="stop">
        /// Stop generation if this token is detected. Or if one of these tokens is detected when providing an array
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-side events as they become available, with the stream terminated by a data: [DONE] message. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="toolChoice">
        /// Default Value: auto
        /// </param>
        /// <param name="tools"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> AgentsCompletionV1AgentsCompletionsPostAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::G.MessagesItem> messages,
            double? frequencyPenalty = default,
            int? maxTokens = default,
            int? n = default,
            bool? parallelToolCalls = default,
            global::G.Prediction? prediction = default,
            double? presencePenalty = default,
            int? randomSeed = default,
            global::G.ResponseFormat? responseFormat = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            global::G.AnyOf<global::G.ToolChoice3, global::G.ToolChoiceEnum?>? toolChoice = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
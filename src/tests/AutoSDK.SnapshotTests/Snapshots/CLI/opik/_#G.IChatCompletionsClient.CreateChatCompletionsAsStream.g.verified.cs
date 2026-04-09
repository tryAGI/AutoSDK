//HintName: G.IChatCompletionsClient.CreateChatCompletionsAsStream.g.cs
#nullable enable

namespace G
{
    public partial interface IChatCompletionsClient
    {
        /// <summary>
        /// Create chat completions<br/>
        /// Create chat completions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.AnyOf<global::G.ChatCompletionResponse, global::G.ErrorMessage>> CreateChatCompletionsAsStreamAsync(

            global::G.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create chat completions<br/>
        /// Create chat completions
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="n"></param>
        /// <param name="streamOptions"></param>
        /// <param name="stop"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="user"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="store"></param>
        /// <param name="metadata"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="serviceTier"></param>
        /// <param name="functions"></param>
        /// <param name="functionCall"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.AnyOf<global::G.ChatCompletionResponse, global::G.ErrorMessage>> CreateChatCompletionsAsStreamAsync(
            string? model = default,
            global::System.Collections.Generic.IList<global::G.Message>? messages = default,
            double? temperature = default,
            double? topP = default,
            int? n = default,
            global::G.StreamOptions? streamOptions = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            int? maxTokens = default,
            int? maxCompletionTokens = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
            string? user = default,
            global::G.ResponseFormat? responseFormat = default,
            int? seed = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            object? toolChoice = default,
            bool? parallelToolCalls = default,
            bool? store = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? reasoningEffort = default,
            string? serviceTier = default,
            global::System.Collections.Generic.IList<global::G.Function>? functions = default,
            global::G.FunctionCall? functionCall = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
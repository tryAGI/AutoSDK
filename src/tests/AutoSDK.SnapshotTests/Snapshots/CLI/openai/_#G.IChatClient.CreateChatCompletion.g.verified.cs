//HintName: G.IChatClient.CreateChatCompletion.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// **Starting a new project?** We recommend trying [Responses](/docs/api-reference/responses) <br/>
        /// to take advantage of the latest OpenAI platform features. Compare<br/>
        /// [Chat Completions with Responses](/docs/guides/responses-vs-chat-completions?api-mode=responses).<br/>
        /// ---<br/>
        /// Creates a model response for the given chat conversation. Learn more in the<br/>
        /// [text generation](/docs/guides/text-generation), [vision](/docs/guides/vision),<br/>
        /// and [audio](/docs/guides/audio) guides.<br/>
        /// Parameter support can differ depending on the model used to generate the<br/>
        /// response, particularly for newer reasoning models. Parameters that are only<br/>
        /// supported for reasoning models are noted below. For the current state of <br/>
        /// unsupported parameters in reasoning models, <br/>
        /// [refer to the reasoning guide](/docs/guides/reasoning).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::G.CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// **Starting a new project?** We recommend trying [Responses](/docs/api-reference/responses) <br/>
        /// to take advantage of the latest OpenAI platform features. Compare<br/>
        /// [Chat Completions with Responses](/docs/guides/responses-vs-chat-completions?api-mode=responses).<br/>
        /// ---<br/>
        /// Creates a model response for the given chat conversation. Learn more in the<br/>
        /// [text generation](/docs/guides/text-generation), [vision](/docs/guides/vision),<br/>
        /// and [audio](/docs/guides/audio) guides.<br/>
        /// Parameter support can differ depending on the model used to generate the<br/>
        /// response, particularly for newer reasoning models. Parameters that are only<br/>
        /// supported for reasoning models are noted below. For the current state of <br/>
        /// unsupported parameters in reasoning models, <br/>
        /// [refer to the reasoning guide](/docs/guides/reasoning).
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
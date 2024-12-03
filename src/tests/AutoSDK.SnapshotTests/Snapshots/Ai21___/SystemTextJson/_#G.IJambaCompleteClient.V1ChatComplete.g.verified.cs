//HintName: G.IJambaCompleteClient.V1ChatComplete.g.cs
#nullable enable

namespace G
{
    public partial interface IJambaCompleteClient
    {
        /// <summary>
        /// Studio Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ChatCompletion, global::System.Collections.Generic.IList<global::G.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            string authorization,
            global::G.LanguageStudioApiServerDataTypesChatChatRequest request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Studio Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="model">
        /// An enumeration.
        /// </param>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="tools"></param>
        /// <param name="n">
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 4096
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="stop"></param>
        /// <param name="stream">
        /// Whether or not to stream the result one token at a time using<br/>
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events).<br/>
        /// This can be useful when waiting for long results where a long wait time for an<br/>
        /// answer can be problematic, such as a chatbot. If set to `True`, then `n` must<br/>
        /// be 1. A streaming response is different than the non-streaming response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mockResponse"></param>
        /// <param name="documents">
        /// Default Value: []
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ChatCompletion, global::System.Collections.Generic.IList<global::G.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            string authorization,
            global::G.ModelName model,
            global::System.Collections.Generic.IList<global::G.MessagesItem> messages,
            int? requestStartTime = default,
            global::System.Collections.Generic.IList<global::G.ToolDefinition>? tools = default,
            int? n = default,
            int? maxTokens = default,
            double? temperature = default,
            double? topP = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            global::G.MockResponseConfig? mockResponse = default,
            global::System.Collections.Generic.IList<global::G.DocumentSchema>? documents = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
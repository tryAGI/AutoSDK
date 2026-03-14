//HintName: G.ILlmChatCompletionsClient.CreateChatCompletionAsStream.g.cs
#nullable enable

namespace G
{
    public partial interface ILlmChatCompletionsClient
    {
        /// <summary>
        /// Creates a model response for the given chat conversation<br/>
        /// The Chat Completions API provides an OpenAI-compatible interface for generating model responses in multi-turn chat conversations. This API enables you to integrate our language models directly into applications designed to work with the OpenAI Chat Completions format, making it easy to leverage Vectara capabilities with minimal changes to existing tools or code.<br/>
        /// Use this API to enable interactive chat experiences that support context-aware responses, streaming output, and token usage tracking.<br/>
        /// The request includes a series of chat messages and optional parameters that control the behavior and structure of the model response. The request body must include the `messages` parameter, an array of message objects (role, content) representing the full conversation so far.<br/>
        /// ### Streaming responses<br/>
        /// If the `stream` parameter is set to `true`, the response appears as a series of text/event-stream parts (also known as chunks). Each chunk includes a `delta` field showing the incremental message update.<br/>
        /// ### Example request<br/>
        /// This example sends a simple chat conversation to the API, asking the assistant for the capital of France. The request includes a system prompt, a user message, and a temperature setting for response variability.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "model": "chat-model-001","messages": [{ "role": "system", "content": "You are a helpful assistant." },<br/>
        ///   { "role": "user", "content": "What is the capital of France?" }<br/>
        /// ],<br/>
        /// "temperature": 0.7,<br/>
        /// "stream": false<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes a generated reply from the assistant, along with token usage statistics. In this example, the model returns a direct answer to a user question.<br/>
        /// ```json<br/>
        /// {<br/>
        /// "id": "chatcmpl-abc123",}<br/>
        /// "object": "chat.completion",<br/>
        /// "created": 1712454830,<br/>
        /// "model": "chat-model-001",<br/>
        /// "choices": [<br/>
        ///   {<br/>
        ///     "index": 0,<br/>
        ///     "message": {<br/>
        ///       "role": "assistant",<br/>
        ///       "content": "The capital of France is Paris."<br/>
        ///   },<br/>
        ///     "finish_reason": "stop"<br/>
        ///   }<br/>
        /// ],<br/>
        /// "usage": {<br/>
        ///   "prompt_tokens": 21,<br/>
        ///   "completion_tokens": 9,<br/>
        ///   "total_tokens": 30<br/>
        ///   } <br/>
        /// } <br/>
        /// ```<br/>
        /// If the input summary is accurate, the `corrected_summary` matches the `original_summary`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(

            global::G.CreateChatCompletionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a model response for the given chat conversation<br/>
        /// The Chat Completions API provides an OpenAI-compatible interface for generating model responses in multi-turn chat conversations. This API enables you to integrate our language models directly into applications designed to work with the OpenAI Chat Completions format, making it easy to leverage Vectara capabilities with minimal changes to existing tools or code.<br/>
        /// Use this API to enable interactive chat experiences that support context-aware responses, streaming output, and token usage tracking.<br/>
        /// The request includes a series of chat messages and optional parameters that control the behavior and structure of the model response. The request body must include the `messages` parameter, an array of message objects (role, content) representing the full conversation so far.<br/>
        /// ### Streaming responses<br/>
        /// If the `stream` parameter is set to `true`, the response appears as a series of text/event-stream parts (also known as chunks). Each chunk includes a `delta` field showing the incremental message update.<br/>
        /// ### Example request<br/>
        /// This example sends a simple chat conversation to the API, asking the assistant for the capital of France. The request includes a system prompt, a user message, and a temperature setting for response variability.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "model": "chat-model-001","messages": [{ "role": "system", "content": "You are a helpful assistant." },<br/>
        ///   { "role": "user", "content": "What is the capital of France?" }<br/>
        /// ],<br/>
        /// "temperature": 0.7,<br/>
        /// "stream": false<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes a generated reply from the assistant, along with token usage statistics. In this example, the model returns a direct answer to a user question.<br/>
        /// ```json<br/>
        /// {<br/>
        /// "id": "chatcmpl-abc123",}<br/>
        /// "object": "chat.completion",<br/>
        /// "created": 1712454830,<br/>
        /// "model": "chat-model-001",<br/>
        /// "choices": [<br/>
        ///   {<br/>
        ///     "index": 0,<br/>
        ///     "message": {<br/>
        ///       "role": "assistant",<br/>
        ///       "content": "The capital of France is Paris."<br/>
        ///   },<br/>
        ///     "finish_reason": "stop"<br/>
        ///   }<br/>
        /// ],<br/>
        /// "usage": {<br/>
        ///   "prompt_tokens": 21,<br/>
        ///   "completion_tokens": 9,<br/>
        ///   "total_tokens": 30<br/>
        ///   } <br/>
        /// } <br/>
        /// ```<br/>
        /// If the input summary is accurate, the `corrected_summary` matches the `original_summary`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="model">
        /// The ID of the model to use. This field is required.
        /// </param>
        /// <param name="messages">
        /// An ordered array of messages that represent the full context of the conversation to date. Each message includes a `role` and `content`.
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format the model must output.<br/>
        /// - `text`: Plain text responses (default).<br/>
        /// - `json_object`: Ensures the response is valid JSON.<br/>
        /// - `json_schema`: Ensures the response conforms to the provided JSON schema.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
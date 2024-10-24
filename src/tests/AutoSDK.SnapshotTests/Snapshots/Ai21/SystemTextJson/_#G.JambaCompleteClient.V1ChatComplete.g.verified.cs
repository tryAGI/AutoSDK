﻿//HintName: G.JambaCompleteClient.V1ChatComplete.g.cs

#nullable enable

namespace G
{
    public partial class JambaCompleteClient
    {
        partial void PrepareV1ChatCompleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string authorization,
            global::G.LanguageStudioApiServerDataTypesChatChatRequest request);
        partial void PrepareV1ChatCompleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string authorization,
            global::G.LanguageStudioApiServerDataTypesChatChatRequest request);
        partial void ProcessV1ChatCompleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1ChatCompleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ChatCompletion, global::System.Collections.Generic.IList<global::G.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            string authorization,
            global::G.LanguageStudioApiServerDataTypesChatChatRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1ChatCompleteArguments(
                httpClient: HttpClient,
                authorization: ref authorization,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/chat/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            __httpRequest.Headers.TryAddWithoutValidation("Authorization", authorization.ToString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1ChatCompleteRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                authorization: authorization,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1ChatCompleteResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1ChatCompleteResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.AnyOf<global::G.ChatCompletion, global::System.Collections.Generic.IList<global::G.ChatCompletionVllmStreamingMessage>>.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Chat Complete<br/>
        /// This is the endpoint for the [Jamba Instruct model](https://docs.ai21.com/docs/jamba-models).<br/>
        /// This is a foundation model that supports both single-turn (question answering,<br/>
        /// text completion) and multi-turn (chat style) interactions.<br/>
        /// You can optionally stream results if you want to get the response as each<br/>
        /// token is generated, rather than waiting for the entire response.
        /// </summary>
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
        /// <param name="documents"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ChatCompletion, global::System.Collections.Generic.IList<global::G.ChatCompletionVllmStreamingMessage>>> V1ChatCompleteAsync(
            string authorization,
            global::G.ModelName model,
            global::System.Collections.Generic.IList<global::G.MessagesItem> messages,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.LanguageStudioApiServerDataTypesChatChatRequest
            {
                Model = model,
                Messages = messages,
                Tools = tools,
                N = n,
                MaxTokens = maxTokens,
                Temperature = temperature,
                TopP = topP,
                Stop = stop,
                Stream = stream,
                MockResponse = mockResponse,
                Documents = documents,
                ResponseFormat = responseFormat,
            };

            return await V1ChatCompleteAsync(
                authorization: authorization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
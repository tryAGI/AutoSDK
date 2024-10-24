﻿//HintName: G.AgentsClient.AgentsCompletionV1AgentsCompletionsPost.g.cs

#nullable enable

namespace G
{
    public partial class AgentsClient
    {
        partial void PrepareAgentsCompletionV1AgentsCompletionsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.AgentsCompletionRequest request);
        partial void PrepareAgentsCompletionV1AgentsCompletionsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AgentsCompletionRequest request);
        partial void ProcessAgentsCompletionV1AgentsCompletionsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentsCompletionV1AgentsCompletionsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Agents Completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> AgentsCompletionV1AgentsCompletionsPostAsync(
            global::G.AgentsCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAgentsCompletionV1AgentsCompletionsPostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/agents/completions",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAgentsCompletionV1AgentsCompletionsPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentsCompletionV1AgentsCompletionsPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessAgentsCompletionV1AgentsCompletionsPostResponseContent(
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
                global::G.ChatCompletionResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Agents Completion
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent to use for this completion.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </param>
        /// <param name="messages">
        /// The prompt(s) to generate completions for, encoded as a list of dict with role and content.<br/>
        /// Example: []
        /// </param>
        /// <param name="minTokens">
        /// The minimum number of tokens to generate in the completion.
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
        public async global::System.Threading.Tasks.Task<global::G.ChatCompletionResponse> AgentsCompletionV1AgentsCompletionsPostAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::G.MessagesItem> messages,
            int? maxTokens = default,
            int? minTokens = default,
            int? randomSeed = default,
            global::G.ResponseFormat? responseFormat = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            global::G.AnyOf<global::G.ToolChoice3, global::G.ToolChoiceEnum?>? toolChoice = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.AgentsCompletionRequest
            {
                AgentId = agentId,
                MaxTokens = maxTokens,
                Messages = messages,
                MinTokens = minTokens,
                RandomSeed = randomSeed,
                ResponseFormat = responseFormat,
                Stop = stop,
                Stream = stream,
                ToolChoice = toolChoice,
                Tools = tools,
            };

            return await AgentsCompletionV1AgentsCompletionsPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
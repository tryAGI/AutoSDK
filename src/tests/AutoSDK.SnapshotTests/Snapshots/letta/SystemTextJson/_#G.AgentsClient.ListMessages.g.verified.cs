//HintName: G.AgentsClient.ListMessages.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class AgentsClient
    {
        partial void PrepareListMessagesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            ref string? before,
            ref string? after,
            int? limit,
            ref global::G.ListMessagesOrder? order,
            ref string? orderBy,
            ref string? groupId,
            ref string? conversationId,
            ref bool? useAssistantMessage,
            ref string? assistantMessageToolName,
            ref string? assistantMessageToolKwarg,
            bool? includeErr);
        partial void PrepareListMessagesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            string? before,
            string? after,
            int? limit,
            global::G.ListMessagesOrder? order,
            string? orderBy,
            string? groupId,
            string? conversationId,
            bool? useAssistantMessage,
            string? assistantMessageToolName,
            string? assistantMessageToolKwarg,
            bool? includeErr);
        partial void ProcessListMessagesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListMessagesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Messages<br/>
        /// Retrieve message history for an agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// Message ID cursor for pagination. Returns messages that come before this message ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Message ID cursor for pagination. Returns messages that come after this message ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of messages to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for messages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="groupId">
        /// Group ID to filter messages by.
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to filter messages by.
        /// </param>
        /// <param name="useAssistantMessage">
        /// Whether to use assistant messages<br/>
        /// Default Value: true
        /// </param>
        /// <param name="assistantMessageToolName">
        /// The name of the designated message tool.<br/>
        /// Default Value: send_message
        /// </param>
        /// <param name="assistantMessageToolKwarg">
        /// The name of the message argument.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="includeErr">
        /// Whether to include error messages and error statuses. For debugging purposes only.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LettaMessageUnion>> ListMessagesAsync(
            string agentId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListMessagesOrder? order = default,
            string? orderBy = default,
            string? groupId = default,
            string? conversationId = default,
            bool? useAssistantMessage = default,
            string? assistantMessageToolName = default,
            string? assistantMessageToolKwarg = default,
            bool? includeErr = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListMessagesArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                before: ref before,
                after: ref after,
                limit: limit,
                order: ref order,
                orderBy: ref orderBy,
                groupId: ref groupId,
                conversationId: ref conversationId,
                useAssistantMessage: ref useAssistantMessage,
                assistantMessageToolName: ref assistantMessageToolName,
                assistantMessageToolKwarg: ref assistantMessageToolKwarg,
                includeErr: includeErr);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/agents/{agentId}/messages",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("before", before)
                .AddOptionalParameter("after", after)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("order_by", orderBy)
                .AddOptionalParameter("group_id", groupId)
                .AddOptionalParameter("conversation_id", conversationId)
                .AddOptionalParameter("use_assistant_message", useAssistantMessage?.ToString().ToLowerInvariant())
                .AddOptionalParameter("assistant_message_tool_name", assistantMessageToolName)
                .AddOptionalParameter("assistant_message_tool_kwarg", assistantMessageToolKwarg)
                .AddOptionalParameter("include_err", includeErr?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListMessagesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                before: before,
                after: after,
                limit: limit,
                order: order,
                orderBy: orderBy,
                groupId: groupId,
                conversationId: conversationId,
                useAssistantMessage: useAssistantMessage,
                assistantMessageToolName: assistantMessageToolName,
                assistantMessageToolKwarg: assistantMessageToolKwarg,
                includeErr: includeErr);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListMessagesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessListMessagesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.LettaMessageUnion>?>(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.IList<global::G.LettaMessageUnion>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}
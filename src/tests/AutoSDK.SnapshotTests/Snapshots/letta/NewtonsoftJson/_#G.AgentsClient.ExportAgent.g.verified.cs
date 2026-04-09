//HintName: G.AgentsClient.ExportAgent.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class AgentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ExportAgentSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ExportAgentSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ExportAgentSecurityRequirement0,
            };
        partial void PrepareExportAgentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            ref int? maxSteps,
            ref bool? useLegacyFormat,
            ref string? conversationId,
            ref bool? scrubMessages,
            global::G.BodyExportAgent request);
        partial void PrepareExportAgentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            int? maxSteps,
            bool? useLegacyFormat,
            string? conversationId,
            bool? scrubMessages,
            global::G.BodyExportAgent request);
        partial void ProcessExportAgentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExportAgentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Export Agent<br/>
        /// Export the serialized JSON representation of an agent, formatted with indentation.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="maxSteps">
        /// Default Value: 100
        /// </param>
        /// <param name="useLegacyFormat">
        /// If True, exports using the legacy single-agent 'v1' format with inline tools/blocks. If False, exports using the new multi-entity 'v2' format, with separate agents, tools, blocks, files, etc.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to export. If provided, uses messages from this conversation instead of the agent's global message history.
        /// </param>
        /// <param name="scrubMessages">
        /// If True, excludes all messages from the export. Useful for sharing agent configs without conversation history.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> ExportAgentAsync(
            string agentId,

            global::G.BodyExportAgent request,
            int? maxSteps = default,
            bool? useLegacyFormat = default,
            string? conversationId = default,
            bool? scrubMessages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareExportAgentArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                maxSteps: ref maxSteps,
                useLegacyFormat: ref useLegacyFormat,
                conversationId: ref conversationId,
                scrubMessages: ref scrubMessages,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ExportAgentSecurityRequirements,
                operationName: "ExportAgentAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/agents/{agentId}/export",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("max_steps", maxSteps?.ToString())
                .AddOptionalParameter("use_legacy_format", useLegacyFormat?.ToString().ToLowerInvariant())
                .AddOptionalParameter("conversation_id", conversationId)
                .AddOptionalParameter("scrub_messages", scrubMessages?.ToString().ToLowerInvariant()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareExportAgentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                maxSteps: maxSteps,
                useLegacyFormat: useLegacyFormat,
                conversationId: conversationId,
                scrubMessages: scrubMessages,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessExportAgentResponse(
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
                ProcessExportAgentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// <summary>
        /// Export Agent<br/>
        /// Export the serialized JSON representation of an agent, formatted with indentation.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="maxSteps">
        /// Default Value: 100
        /// </param>
        /// <param name="useLegacyFormat">
        /// If True, exports using the legacy single-agent 'v1' format with inline tools/blocks. If False, exports using the new multi-entity 'v2' format, with separate agents, tools, blocks, files, etc.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to export. If provided, uses messages from this conversation instead of the agent's global message history.
        /// </param>
        /// <param name="scrubMessages">
        /// If True, excludes all messages from the export. Useful for sharing agent configs without conversation history.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="spec"></param>
        /// <param name="legacySpec"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ExportAgentAsync(
            string agentId,
            int? maxSteps = default,
            bool? useLegacyFormat = default,
            string? conversationId = default,
            bool? scrubMessages = default,
            global::G.AgentFileSchema? spec = default,
            global::G.LettaSerializeSchemasPydanticAgentSchemaAgentSchema? legacySpec = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyExportAgent
            {
                Spec = spec,
                LegacySpec = legacySpec,
            };

            return await ExportAgentAsync(
                agentId: agentId,
                maxSteps: maxSteps,
                useLegacyFormat: useLegacyFormat,
                conversationId: conversationId,
                scrubMessages: scrubMessages,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
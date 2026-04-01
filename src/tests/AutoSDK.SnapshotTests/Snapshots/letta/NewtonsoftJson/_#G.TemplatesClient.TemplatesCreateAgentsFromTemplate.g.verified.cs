//HintName: G.TemplatesClient.TemplatesCreateAgentsFromTemplate.g.cs

#nullable enable

namespace G
{
    public partial class TemplatesClient
    {
        partial void PrepareTemplatesCreateAgentsFromTemplateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string templateVersion,
            global::G.TemplatesCreateAgentsFromTemplateRequest request);
        partial void PrepareTemplatesCreateAgentsFromTemplateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string templateVersion,
            global::G.TemplatesCreateAgentsFromTemplateRequest request);
        partial void ProcessTemplatesCreateAgentsFromTemplateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create Agents From Template<br/>
        /// Creates an Agent or multiple Agents from a template
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateVersion"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task TemplatesCreateAgentsFromTemplateAsync(
            string projectId,
            string templateVersion,

            global::G.TemplatesCreateAgentsFromTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTemplatesCreateAgentsFromTemplateArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                templateVersion: ref templateVersion,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/templates/{projectId}/{templateVersion}/agents",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTemplatesCreateAgentsFromTemplateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                templateVersion: templateVersion,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTemplatesCreateAgentsFromTemplateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 402
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::G.TemplatesCreateAgentsFromTemplateResponse? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::G.TemplatesCreateAgentsFromTemplateResponse.FromJson(__content_402, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::G.TemplatesCreateAgentsFromTemplateResponse.FromJson(__content_402, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::G.ApiException<global::G.TemplatesCreateAgentsFromTemplateResponse>(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
                    ResponseObject = __value_402,
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Create Agents From Template<br/>
        /// Creates an Agent or multiple Agents from a template
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateVersion"></param>
        /// <param name="tags">
        /// The tags to assign to the agent
        /// </param>
        /// <param name="agentName">
        /// The name of the agent, optional otherwise a random one will be assigned
        /// </param>
        /// <param name="initialMessageSequence">
        /// Set an initial sequence of messages, if not provided, the agent will start with the default message sequence, if an empty array is provided, the agent will start with no messages
        /// </param>
        /// <param name="memoryVariables">
        /// The memory variables to assign to the agent
        /// </param>
        /// <param name="toolVariables">
        /// The tool variables to assign to the agent
        /// </param>
        /// <param name="identityIds">
        /// The identity ids to assign to the agent
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TemplatesCreateAgentsFromTemplateAsync(
            string projectId,
            string templateVersion,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? agentName = default,
            global::System.Collections.Generic.IList<global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem>? initialMessageSequence = default,
            global::System.Collections.Generic.Dictionary<string, string>? memoryVariables = default,
            global::System.Collections.Generic.Dictionary<string, string>? toolVariables = default,
            global::System.Collections.Generic.IList<string>? identityIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TemplatesCreateAgentsFromTemplateRequest
            {
                Tags = tags,
                AgentName = agentName,
                InitialMessageSequence = initialMessageSequence,
                MemoryVariables = memoryVariables,
                ToolVariables = toolVariables,
                IdentityIds = identityIds,
            };

            await TemplatesCreateAgentsFromTemplateAsync(
                projectId: projectId,
                templateVersion: templateVersion,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
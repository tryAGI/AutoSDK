//HintName: G.AgentsClient.ModifyAgent.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class AgentsClient
    {
        partial void PrepareModifyAgentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            global::G.UpdateAgent request);
        partial void PrepareModifyAgentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            global::G.UpdateAgent request);
        partial void ProcessModifyAgentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModifyAgentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Modify Agent<br/>
        /// Update an existing agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AgentState> ModifyAgentAsync(
            string agentId,

            global::G.UpdateAgent request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareModifyAgentArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/agents/{agentId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareModifyAgentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModifyAgentResponse(
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
                ProcessModifyAgentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AgentState.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AgentState.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Modify Agent<br/>
        /// Update an existing agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="name">
        /// The name of the agent.
        /// </param>
        /// <param name="toolIds">
        /// The ids of the tools used by the agent.
        /// </param>
        /// <param name="folderIds">
        /// The ids of the folders used by the agent.
        /// </param>
        /// <param name="blockIds">
        /// The ids of the blocks used by the agent.
        /// </param>
        /// <param name="tags">
        /// The tags associated with the agent.
        /// </param>
        /// <param name="system">
        /// The system prompt used by the agent.
        /// </param>
        /// <param name="toolRules">
        /// The tool rules governing the agent.
        /// </param>
        /// <param name="messageIds">
        /// The ids of the messages in the agent's in-context memory.
        /// </param>
        /// <param name="description">
        /// The description of the agent.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the agent.
        /// </param>
        /// <param name="toolExecEnvironmentVariables">
        /// Deprecated: use `secrets` field instead
        /// </param>
        /// <param name="secrets">
        /// The environment variables for tool execution specific to this agent.
        /// </param>
        /// <param name="projectId">
        /// The id of the project the agent belongs to.
        /// </param>
        /// <param name="templateId">
        /// The id of the template the agent belongs to.
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template id of the agent.
        /// </param>
        /// <param name="identityIds">
        /// The ids of the identities associated with this agent.
        /// </param>
        /// <param name="messageBufferAutoclear">
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.
        /// </param>
        /// <param name="model">
        /// The model handle used by the agent (format: provider/model-name).
        /// </param>
        /// <param name="embedding">
        /// The embedding model handle used by the agent (format: provider/model-name).
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for the agent.
        /// </param>
        /// <param name="compactionSettings">
        /// The compaction settings configuration used for compaction.
        /// </param>
        /// <param name="contextWindowLimit">
        /// The context window limit used by the agent.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration used by the agent.
        /// </param>
        /// <param name="enableSleeptime">
        /// If set to True, memory management will move to a background agent thread.
        /// </param>
        /// <param name="lastRunCompletion">
        /// The timestamp when the agent last completed a run.
        /// </param>
        /// <param name="lastRunDurationMs">
        /// The duration in milliseconds of the agent's last run.
        /// </param>
        /// <param name="lastStopReason">
        /// The stop reason from the agent's last run.
        /// </param>
        /// <param name="timezone">
        /// The timezone of the agent (IANA format).
        /// </param>
        /// <param name="maxFilesOpen">
        /// Maximum number of files that can be open at once for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </param>
        /// <param name="perFileViewWindowCharLimit">
        /// The per-file view window character limit for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </param>
        /// <param name="hidden">
        /// If set to True, the agent will be hidden.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AgentState> ModifyAgentAsync(
            string agentId,
            string? name = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            global::System.Collections.Generic.IList<string>? folderIds = default,
            global::System.Collections.Generic.IList<string>? blockIds = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? system = default,
            global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item4>? toolRules = default,
            global::System.Collections.Generic.IList<string>? messageIds = default,
            string? description = default,
            object? metadata = default,
            global::System.Collections.Generic.Dictionary<string, string>? toolExecEnvironmentVariables = default,
            global::System.Collections.Generic.Dictionary<string, string>? secrets = default,
            string? projectId = default,
            string? templateId = default,
            string? baseTemplateId = default,
            global::System.Collections.Generic.IList<string>? identityIds = default,
            bool? messageBufferAutoclear = default,
            string? model = default,
            string? embedding = default,
            global::G.ModelSettingsVariant18? modelSettings = default,
            global::G.CompactionSettingsInput? compactionSettings = default,
            int? contextWindowLimit = default,
            global::G.EmbeddingConfig? embeddingConfig = default,
            bool? enableSleeptime = default,
            global::System.DateTime? lastRunCompletion = default,
            int? lastRunDurationMs = default,
            global::G.StopReasonType? lastStopReason = default,
            string? timezone = default,
            int? maxFilesOpen = default,
            int? perFileViewWindowCharLimit = default,
            bool? hidden = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.UpdateAgent
            {
                Name = name,
                ToolIds = toolIds,
                FolderIds = folderIds,
                BlockIds = blockIds,
                Tags = tags,
                System = system,
                ToolRules = toolRules,
                MessageIds = messageIds,
                Description = description,
                Metadata = metadata,
                ToolExecEnvironmentVariables = toolExecEnvironmentVariables,
                Secrets = secrets,
                ProjectId = projectId,
                TemplateId = templateId,
                BaseTemplateId = baseTemplateId,
                IdentityIds = identityIds,
                MessageBufferAutoclear = messageBufferAutoclear,
                Model = model,
                Embedding = embedding,
                ModelSettings = modelSettings,
                CompactionSettings = compactionSettings,
                ContextWindowLimit = contextWindowLimit,
                EmbeddingConfig = embeddingConfig,
                EnableSleeptime = enableSleeptime,
                LastRunCompletion = lastRunCompletion,
                LastRunDurationMs = lastRunDurationMs,
                LastStopReason = lastStopReason,
                Timezone = timezone,
                MaxFilesOpen = maxFilesOpen,
                PerFileViewWindowCharLimit = perFileViewWindowCharLimit,
                Hidden = hidden,
            };

            return await ModifyAgentAsync(
                agentId: agentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
//HintName: G.WorkspaceClient.GetWorkspaceResourcesByResourceId.g.cs

#nullable enable

namespace G
{
    public partial class WorkspaceClient
    {
        partial void PrepareGetWorkspaceResourcesByResourceIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string resourceId,
            ref global::G.WorkspaceResourceType resourceType,
            ref string? xiApiKey);
        partial void PrepareGetWorkspaceResourcesByResourceIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string resourceId,
            global::G.WorkspaceResourceType resourceType,
            string? xiApiKey);
        partial void ProcessGetWorkspaceResourcesByResourceIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetWorkspaceResourcesByResourceIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Resource<br/>
        /// Gets the metadata of a resource by ID.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="resourceType">
        /// Resource type of the target resource.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ResourceMetadataResponseModel> GetWorkspaceResourcesByResourceIdAsync(
            string resourceId,
            global::G.WorkspaceResourceType resourceType,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWorkspaceResourcesByResourceIdArguments(
                httpClient: HttpClient,
                resourceId: ref resourceId,
                resourceType: ref resourceType,
                xiApiKey: ref xiApiKey);

            var resourceTypeValue = resourceType switch
            {
                global::G.WorkspaceResourceType.Voice => "voice",
                global::G.WorkspaceResourceType.VoiceCollection => "voice_collection",
                global::G.WorkspaceResourceType.PronunciationDictionary => "pronunciation_dictionary",
                global::G.WorkspaceResourceType.Dubbing => "dubbing",
                global::G.WorkspaceResourceType.Project => "project",
                global::G.WorkspaceResourceType.ConvaiAgents => "convai_agents",
                global::G.WorkspaceResourceType.ConvaiKnowledgeBaseDocuments => "convai_knowledge_base_documents",
                global::G.WorkspaceResourceType.ConvaiTools => "convai_tools",
                global::G.WorkspaceResourceType.ConvaiSettings => "convai_settings",
                global::G.WorkspaceResourceType.ConvaiSecrets => "convai_secrets",
                global::G.WorkspaceResourceType.WorkspaceAuthConnections => "workspace_auth_connections",
                global::G.WorkspaceResourceType.ConvaiPhoneNumbers => "convai_phone_numbers",
                global::G.WorkspaceResourceType.ConvaiMcpServers => "convai_mcp_servers",
                global::G.WorkspaceResourceType.ConvaiApiIntegrationConnections => "convai_api_integration_connections",
                global::G.WorkspaceResourceType.ConvaiApiIntegrationTriggerConnections => "convai_api_integration_trigger_connections",
                global::G.WorkspaceResourceType.ConvaiBatchCalls => "convai_batch_calls",
                global::G.WorkspaceResourceType.ConvaiAgentResponseTests => "convai_agent_response_tests",
                global::G.WorkspaceResourceType.ConvaiTestSuiteInvocations => "convai_test_suite_invocations",
                global::G.WorkspaceResourceType.ConvaiCrawlJobs => "convai_crawl_jobs",
                global::G.WorkspaceResourceType.ConvaiCrawlTasks => "convai_crawl_tasks",
                global::G.WorkspaceResourceType.ConvaiWhatsappAccounts => "convai_whatsapp_accounts",
                global::G.WorkspaceResourceType.ConvaiAgentVersions => "convai_agent_versions",
                global::G.WorkspaceResourceType.ConvaiAgentBranches => "convai_agent_branches",
                global::G.WorkspaceResourceType.ConvaiAgentVersionsDeployments => "convai_agent_versions_deployments",
                global::G.WorkspaceResourceType.ConvaiMemoryEntries => "convai_memory_entries",
                global::G.WorkspaceResourceType.ConvaiCoachingProposals => "convai_coaching_proposals",
                global::G.WorkspaceResourceType.Dashboard => "dashboard",
                global::G.WorkspaceResourceType.DashboardConfiguration => "dashboard_configuration",
                global::G.WorkspaceResourceType.ConvaiAgentDrafts => "convai_agent_drafts",
                global::G.WorkspaceResourceType.ResourceLocators => "resource_locators",
                global::G.WorkspaceResourceType.Assets => "assets",
                global::G.WorkspaceResourceType.ContentGenerations => "content_generations",
                global::G.WorkspaceResourceType.ContentTemplates => "content_templates",
                global::G.WorkspaceResourceType.Songs => "songs",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/workspace/resources/{resourceId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("resource_type", resourceType.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetWorkspaceResourcesByResourceIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                resourceId: resourceId,
                resourceType: resourceType,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetWorkspaceResourcesByResourceIdResponse(
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
                ProcessGetWorkspaceResourcesByResourceIdResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ResourceMetadataResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ResourceMetadataResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
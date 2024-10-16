﻿//HintName: G.ActionsClient.ActionsCreateSelfHostedRunnerGroupForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsCreateSelfHostedRunnerGroupForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequest request);
        partial void PrepareActionsCreateSelfHostedRunnerGroupForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequest request);
        partial void ProcessActionsCreateSelfHostedRunnerGroupForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsCreateSelfHostedRunnerGroupForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a self-hosted runner group for an organization<br/>
        /// Creates a new self-hosted runner group for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsCreateSelfHostedRunnerGroupForOrgAsync(
            string org,
            global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsCreateSelfHostedRunnerGroupForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/runner-groups",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsCreateSelfHostedRunnerGroupForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsCreateSelfHostedRunnerGroupForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsCreateSelfHostedRunnerGroupForOrgResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::G.RunnerGroupsOrg.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a self-hosted runner group for an organization<br/>
        /// Creates a new self-hosted runner group for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// Name of the runner group.
        /// </param>
        /// <param name="visibility">
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or limit access to private repositories.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs that can access the runner group.
        /// </param>
        /// <param name="runners">
        /// List of runner IDs to add to the runner group.
        /// </param>
        /// <param name="allowsPublicRepositories">
        /// Whether the runner group can be used by `public` repositories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="restrictedToWorkflows">
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="selectedWorkflows">
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsCreateSelfHostedRunnerGroupForOrgAsync(
            string org,
            string name,
            global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility? visibility = global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility.All,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Collections.Generic.IList<int>? runners = default,
            bool? allowsPublicRepositories = false,
            bool? restrictedToWorkflows = false,
            global::System.Collections.Generic.IList<string>? selectedWorkflows = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequest
            {
                Name = name,
                Visibility = visibility,
                SelectedRepositoryIds = selectedRepositoryIds,
                Runners = runners,
                AllowsPublicRepositories = allowsPublicRepositories,
                RestrictedToWorkflows = restrictedToWorkflows,
                SelectedWorkflows = selectedWorkflows,
            };

            return await ActionsCreateSelfHostedRunnerGroupForOrgAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
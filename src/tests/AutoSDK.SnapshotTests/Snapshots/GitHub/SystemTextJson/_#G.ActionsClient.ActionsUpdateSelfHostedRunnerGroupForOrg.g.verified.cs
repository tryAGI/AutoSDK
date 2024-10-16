﻿//HintName: G.ActionsClient.ActionsUpdateSelfHostedRunnerGroupForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsUpdateSelfHostedRunnerGroupForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int runnerGroupId,
            global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequest request);
        partial void PrepareActionsUpdateSelfHostedRunnerGroupForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int runnerGroupId,
            global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequest request);
        partial void ProcessActionsUpdateSelfHostedRunnerGroupForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsUpdateSelfHostedRunnerGroupForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a self-hosted runner group for an organization<br/>
        /// Updates the `name` and `visibility` of a self-hosted runner group in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsUpdateSelfHostedRunnerGroupForOrgAsync(
            string org,
            int runnerGroupId,
            global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsUpdateSelfHostedRunnerGroupForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                runnerGroupId: ref runnerGroupId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/runner-groups/{runnerGroupId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareActionsUpdateSelfHostedRunnerGroupForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                runnerGroupId: runnerGroupId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsUpdateSelfHostedRunnerGroupForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsUpdateSelfHostedRunnerGroupForOrgResponseContent(
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
        /// Update a self-hosted runner group for an organization<br/>
        /// Updates the `name` and `visibility` of a self-hosted runner group in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="name">
        /// Name of the runner group.
        /// </param>
        /// <param name="visibility">
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or all private repositories.
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
        public async global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsUpdateSelfHostedRunnerGroupForOrgAsync(
            string org,
            int runnerGroupId,
            string name,
            global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility? visibility = default,
            bool? allowsPublicRepositories = false,
            bool? restrictedToWorkflows = false,
            global::System.Collections.Generic.IList<string>? selectedWorkflows = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequest
            {
                Name = name,
                Visibility = visibility,
                AllowsPublicRepositories = allowsPublicRepositories,
                RestrictedToWorkflows = restrictedToWorkflows,
                SelectedWorkflows = selectedWorkflows,
            };

            return await ActionsUpdateSelfHostedRunnerGroupForOrgAsync(
                org: org,
                runnerGroupId: runnerGroupId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
//HintName: G.ActionsClient.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsRemoveCustomLabelFromSelfHostedRunnerForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int runnerId,
            ref string name);
        partial void PrepareActionsRemoveCustomLabelFromSelfHostedRunnerForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int runnerId,
            string name);
        partial void ProcessActionsRemoveCustomLabelFromSelfHostedRunnerForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsRemoveCustomLabelFromSelfHostedRunnerForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove a custom label from a self-hosted runner for an organization<br/>
        /// Remove a custom label from a self-hosted runner configured<br/>
        /// in an organization. Returns the remaining labels from the runner.<br/>
        /// This endpoint returns a `404 Not Found` status if the custom label is not<br/>
        /// present on the runner.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgResponse> ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActionsRemoveCustomLabelFromSelfHostedRunnerForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                runnerId: ref runnerId,
                name: ref name);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/runners/{runnerId}/labels/{name}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsRemoveCustomLabelFromSelfHostedRunnerForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                runnerId: runnerId,
                name: name);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsRemoveCustomLabelFromSelfHostedRunnerForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsRemoveCustomLabelFromSelfHostedRunnerForOrgResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}
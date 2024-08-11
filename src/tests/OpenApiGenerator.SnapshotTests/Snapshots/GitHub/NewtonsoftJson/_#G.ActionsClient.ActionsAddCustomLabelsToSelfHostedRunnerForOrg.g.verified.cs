//HintName: G.ActionsClient.ActionsAddCustomLabelsToSelfHostedRunnerForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsAddCustomLabelsToSelfHostedRunnerForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int runnerId,
            global::G.ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest request);
        partial void PrepareActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int runnerId,
            global::G.ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest request);
        partial void ProcessActionsAddCustomLabelsToSelfHostedRunnerForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsAddCustomLabelsToSelfHostedRunnerForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add custom labels to a self-hosted runner for an organization<br/>
        /// Adds custom labels to a self-hosted runner configured in an organization.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsAddCustomLabelsToSelfHostedRunnerForOrgResponse> ActionsAddCustomLabelsToSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            global::G.ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsAddCustomLabelsToSelfHostedRunnerForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                runnerId: ref runnerId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/actions/runners/{runnerId}/labels", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                runnerId: runnerId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsAddCustomLabelsToSelfHostedRunnerForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsAddCustomLabelsToSelfHostedRunnerForOrgResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ActionsAddCustomLabelsToSelfHostedRunnerForOrgResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add custom labels to a self-hosted runner for an organization<br/>
        /// Adds custom labels to a self-hosted runner configured in an organization.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsAddCustomLabelsToSelfHostedRunnerForOrgResponse> ActionsAddCustomLabelsToSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest
            {
                Labels = labels,
            };

            return await ActionsAddCustomLabelsToSelfHostedRunnerForOrgAsync(
                org: org,
                runnerId: runnerId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
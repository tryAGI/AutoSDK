//HintName: G.ActionsClient.ActionsGenerateRunnerJitconfigForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsGenerateRunnerJitconfigForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.ActionsGenerateRunnerJitconfigForOrgRequest request);
        partial void PrepareActionsGenerateRunnerJitconfigForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.ActionsGenerateRunnerJitconfigForOrgRequest request);
        partial void ProcessActionsGenerateRunnerJitconfigForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsGenerateRunnerJitconfigForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create configuration for a just-in-time runner for an organization<br/>
        /// Generates a configuration that can be passed to the runner application at startup.<br/>
        /// The authenticated user must have admin access to the organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsGenerateRunnerJitconfigForOrgResponse> ActionsGenerateRunnerJitconfigForOrgAsync(
            string org,
            global::G.ActionsGenerateRunnerJitconfigForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsGenerateRunnerJitconfigForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/runners/generate-jitconfig",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsGenerateRunnerJitconfigForOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsGenerateRunnerJitconfigForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessActionsGenerateRunnerJitconfigForOrgResponseContent(
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
                global::G.ActionsGenerateRunnerJitconfigForOrgResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create configuration for a just-in-time runner for an organization<br/>
        /// Generates a configuration that can be passed to the runner application at startup.<br/>
        /// The authenticated user must have admin access to the organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the new runner.
        /// </param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group to register the runner to.
        /// </param>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner. **Minimum items**: 1. **Maximum items**: 100.
        /// </param>
        /// <param name="workFolder">
        /// The working directory to be used for job execution, relative to the runner install directory.<br/>
        /// Default Value: _work
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsGenerateRunnerJitconfigForOrgResponse> ActionsGenerateRunnerJitconfigForOrgAsync(
            string org,
            string name,
            int runnerGroupId,
            global::System.Collections.Generic.IList<string> labels,
            string? workFolder = "_work",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ActionsGenerateRunnerJitconfigForOrgRequest
            {
                Name = name,
                RunnerGroupId = runnerGroupId,
                Labels = labels,
                WorkFolder = workFolder,
            };

            return await ActionsGenerateRunnerJitconfigForOrgAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
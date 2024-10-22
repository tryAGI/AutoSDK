//HintName: G.ActionsClient.ActionsAddCustomLabelsToSelfHostedRunnerForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsAddCustomLabelsToSelfHostedRunnerForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int runnerId,
            global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest request);
        partial void PrepareActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int runnerId,
            global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest request);
        partial void ProcessActionsAddCustomLabelsToSelfHostedRunnerForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsAddCustomLabelsToSelfHostedRunnerForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add custom labels to a self-hosted runner for a repository<br/>
        /// Adds custom labels to a self-hosted runner configured in a repository.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoResponse> ActionsAddCustomLabelsToSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsAddCustomLabelsToSelfHostedRunnerForRepoArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                runnerId: ref runnerId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/actions/runners/{runnerId}/labels",
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
            PrepareActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                runnerId: runnerId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsAddCustomLabelsToSelfHostedRunnerForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessActionsAddCustomLabelsToSelfHostedRunnerForRepoResponseContent(
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
                global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add custom labels to a self-hosted runner for a repository<br/>
        /// Adds custom labels to a self-hosted runner configured in a repository.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoResponse> ActionsAddCustomLabelsToSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoRequest
            {
                Labels = labels,
            };

            return await ActionsAddCustomLabelsToSelfHostedRunnerForRepoAsync(
                owner: owner,
                repo: repo,
                runnerId: runnerId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
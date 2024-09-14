//HintName: G.ReposClient.ReposCreateCommitStatus.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateCommitStatusArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string sha,
            global::G.ReposCreateCommitStatusRequest request);
        partial void PrepareReposCreateCommitStatusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string sha,
            global::G.ReposCreateCommitStatusRequest request);
        partial void ProcessReposCreateCommitStatusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateCommitStatusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a commit status<br/>
        /// Users with push access in a repository can create commit statuses for a given SHA.<br/>
        /// Note: there is a limit of 1000 statuses per `sha` and `context` within a repository. Attempts to create more than 1000 statuses will result in a validation error.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Status> ReposCreateCommitStatusAsync(
            string owner,
            string repo,
            string sha,
            global::G.ReposCreateCommitStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateCommitStatusArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                sha: ref sha,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/statuses/{sha}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateCommitStatusRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                sha: sha,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposCreateCommitStatusResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateCommitStatusResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Status?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a commit status<br/>
        /// Users with push access in a repository can create commit statuses for a given SHA.<br/>
        /// Note: there is a limit of 1000 statuses per `sha` and `context` within a repository. Attempts to create more than 1000 statuses will result in a validation error.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="state">
        /// The state of the status.
        /// </param>
        /// <param name="targetUrl">
        /// The target URL to associate with this status. This URL will be linked from the GitHub UI to allow users to easily see the source of the status.  <br/>
        /// For example, if your continuous integration system is posting build status, you would want to provide the deep link for the build output for this specific SHA:  <br/>
        /// `http://ci.example.com/user/repo/build/sha`
        /// </param>
        /// <param name="description">
        /// A short description of the status.
        /// </param>
        /// <param name="context">
        /// A string label to differentiate this status from the status of other systems. This field is case-insensitive.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Status> ReposCreateCommitStatusAsync(
            string owner,
            string repo,
            string sha,
            global::G.ReposCreateCommitStatusRequestState state,
            string? targetUrl = default,
            string? description = default,
            string? context = "default",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateCommitStatusRequest
            {
                State = state,
                TargetUrl = targetUrl,
                Description = description,
                Context = context,
            };

            return await ReposCreateCommitStatusAsync(
                owner: owner,
                repo: repo,
                sha: sha,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
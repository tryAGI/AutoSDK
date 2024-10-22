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
                client: HttpClient);
            PrepareReposCreateCommitStatusArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                sha: ref sha,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/statuses/{sha}",
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
            PrepareReposCreateCommitStatusRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                sha: sha,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposCreateCommitStatusResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposCreateCommitStatusResponseContent(
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
                global::G.Status.FromJson(__content, JsonSerializerOptions) ??
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
            var __request = new global::G.ReposCreateCommitStatusRequest
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
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
//HintName: G.ReposClient.ReposCreatePagesDeployment.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreatePagesDeploymentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.ReposCreatePagesDeploymentRequest request);
        partial void PrepareReposCreatePagesDeploymentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ReposCreatePagesDeploymentRequest request);
        partial void ProcessReposCreatePagesDeploymentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreatePagesDeploymentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a GitHub Pages deployment<br/>
        /// Create a GitHub Pages deployment for a repository.<br/>
        /// The authenticated user must have write permission to the repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PageDeployment> ReposCreatePagesDeploymentAsync(
            string owner,
            string repo,
            global::G.ReposCreatePagesDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposCreatePagesDeploymentArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/pages/deployments",
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
            PrepareReposCreatePagesDeploymentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposCreatePagesDeploymentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposCreatePagesDeploymentResponseContent(
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
                global::G.PageDeployment.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a GitHub Pages deployment<br/>
        /// Create a GitHub Pages deployment for a repository.<br/>
        /// The authenticated user must have write permission to the repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="artifactId">
        /// The ID of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </param>
        /// <param name="artifactUrl">
        /// The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </param>
        /// <param name="environment">
        /// The target environment for this GitHub Pages deployment.<br/>
        /// Default Value: github-pages
        /// </param>
        /// <param name="pagesBuildVersion">
        /// A unique string that represents the version of the build for this deployment.<br/>
        /// Default Value: GITHUB_SHA
        /// </param>
        /// <param name="oidcToken">
        /// The OIDC token issued by GitHub Actions certifying the origin of the deployment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PageDeployment> ReposCreatePagesDeploymentAsync(
            string owner,
            string repo,
            string pagesBuildVersion,
            string oidcToken,
            double? artifactId = default,
            string? artifactUrl = default,
            string? environment = "github-pages",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ReposCreatePagesDeploymentRequest
            {
                ArtifactId = artifactId,
                ArtifactUrl = artifactUrl,
                Environment = environment,
                PagesBuildVersion = pagesBuildVersion,
                OidcToken = oidcToken,
            };

            return await ReposCreatePagesDeploymentAsync(
                owner: owner,
                repo: repo,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
//HintName: G.ReposClient.ReposCreatePagesDeployment.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a GitHub Pages deployment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PageDeployment> ReposCreatePagesDeploymentAsync(
            string owner,
            string repo,
            ReposCreatePagesDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pages/deployments", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<PageDeployment?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a GitHub Pages deployment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="artifactId"></param>
        /// <param name="artifactUrl"></param>
        /// <param name="environment"></param>
        /// <param name="pagesBuildVersion"></param>
        /// <param name="oidcToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PageDeployment> ReposCreatePagesDeploymentAsync(
            string owner,
            string repo,
            string pagesBuildVersion,
            string oidcToken,
            double artifactId = default,
            string? artifactUrl = default,
            string? environment = "github-pages",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreatePagesDeploymentRequest
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
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
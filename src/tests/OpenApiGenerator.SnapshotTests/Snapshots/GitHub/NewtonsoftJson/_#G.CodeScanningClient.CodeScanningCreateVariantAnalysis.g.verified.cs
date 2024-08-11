//HintName: G.CodeScanningClient.CodeScanningCreateVariantAnalysis.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningCreateVariantAnalysisArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.CodeScanningCreateVariantAnalysisRequest request);
        partial void PrepareCodeScanningCreateVariantAnalysisRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.CodeScanningCreateVariantAnalysisRequest request);
        partial void ProcessCodeScanningCreateVariantAnalysisResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningCreateVariantAnalysisResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a CodeQL variant analysis<br/>
        /// Creates a new CodeQL variant analysis, which will run a CodeQL query against one or more repositories.<br/>
        /// Get started by learning more about [running CodeQL queries at scale with Multi-Repository Variant Analysis](https://docs.github.com/code-security/codeql-for-vs-code/getting-started-with-codeql-for-vs-code/running-codeql-queries-at-scale-with-multi-repository-variant-analysis).<br/>
        /// Use the `owner` and `repo` parameters in the URL to specify the controller repository that<br/>
        /// will be used for running GitHub Actions workflows and storing the results of the CodeQL variant analysis.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodeScanningVariantAnalysis> CodeScanningCreateVariantAnalysisAsync(
            string owner,
            string repo,
            global::G.CodeScanningCreateVariantAnalysisRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCodeScanningCreateVariantAnalysisArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/code-scanning/codeql/variant-analyses", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodeScanningCreateVariantAnalysisRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodeScanningCreateVariantAnalysisResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodeScanningCreateVariantAnalysisResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningVariantAnalysis?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a CodeQL variant analysis<br/>
        /// Creates a new CodeQL variant analysis, which will run a CodeQL query against one or more repositories.<br/>
        /// Get started by learning more about [running CodeQL queries at scale with Multi-Repository Variant Analysis](https://docs.github.com/code-security/codeql-for-vs-code/getting-started-with-codeql-for-vs-code/running-codeql-queries-at-scale-with-multi-repository-variant-analysis).<br/>
        /// Use the `owner` and `repo` parameters in the URL to specify the controller repository that<br/>
        /// will be used for running GitHub Actions workflows and storing the results of the CodeQL variant analysis.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="language">
        /// The language targeted by the CodeQL query
        /// </param>
        /// <param name="queryPack">
        /// A Base64-encoded tarball containing a CodeQL query and all its dependencies
        /// </param>
        /// <param name="repositories">
        /// List of repository names (in the form `owner/repo-name`) to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        /// <param name="repositoryLists">
        /// List of repository lists to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        /// <param name="repositoryOwners">
        /// List of organization or user names whose repositories the query should be run against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodeScanningVariantAnalysis> CodeScanningCreateVariantAnalysisAsync(
            string owner,
            string repo,
            global::G.CodeScanningVariantAnalysisLanguage? language,
            string queryPack,
            global::System.Collections.Generic.IList<string>? repositories = default,
            global::System.Collections.Generic.IList<string>? repositoryLists = default,
            global::System.Collections.Generic.IList<string>? repositoryOwners = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CodeScanningCreateVariantAnalysisRequest
            {
                Language = language,
                QueryPack = queryPack,
                Repositories = repositories,
                RepositoryLists = repositoryLists,
                RepositoryOwners = repositoryOwners,
            };

            return await CodeScanningCreateVariantAnalysisAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
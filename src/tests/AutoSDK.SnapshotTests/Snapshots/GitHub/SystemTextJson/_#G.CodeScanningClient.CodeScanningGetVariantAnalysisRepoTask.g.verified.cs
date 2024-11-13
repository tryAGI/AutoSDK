//HintName: G.CodeScanningClient.CodeScanningGetVariantAnalysisRepoTask.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningGetVariantAnalysisRepoTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int codeqlVariantAnalysisId,
            ref string repoOwner,
            ref string repoName);
        partial void PrepareCodeScanningGetVariantAnalysisRepoTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int codeqlVariantAnalysisId,
            string repoOwner,
            string repoName);
        partial void ProcessCodeScanningGetVariantAnalysisRepoTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningGetVariantAnalysisRepoTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get the analysis status of a repository in a CodeQL variant analysis<br/>
        /// Gets the analysis status of a repository in a CodeQL variant analysis.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="codeqlVariantAnalysisId"></param>
        /// <param name="repoOwner"></param>
        /// <param name="repoName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodeScanningVariantAnalysisRepoTask> CodeScanningGetVariantAnalysisRepoTaskAsync(
            string owner,
            string repo,
            int codeqlVariantAnalysisId,
            string repoOwner,
            string repoName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCodeScanningGetVariantAnalysisRepoTaskArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                codeqlVariantAnalysisId: ref codeqlVariantAnalysisId,
                repoOwner: ref repoOwner,
                repoName: ref repoName);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/code-scanning/codeql/variant-analyses/{codeqlVariantAnalysisId}/repos/{repoOwner}/{repoName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCodeScanningGetVariantAnalysisRepoTaskRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                codeqlVariantAnalysisId: codeqlVariantAnalysisId,
                repoOwner: repoOwner,
                repoName: repoName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodeScanningGetVariantAnalysisRepoTaskResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Resource not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.BasicError? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.BasicError.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Service unavailable
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::G.CodeScanningGetVariantAnalysisRepoTaskResponse? __value_503 = null;
                if (ReadResponseAsString)
                {
                    __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = global::G.CodeScanningGetVariantAnalysisRepoTaskResponse.FromJson(__content_503, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = await global::G.CodeScanningGetVariantAnalysisRepoTaskResponse.FromJsonStreamAsync(__contentStream_503, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CodeScanningGetVariantAnalysisRepoTaskResponse>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCodeScanningGetVariantAnalysisRepoTaskResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.CodeScanningVariantAnalysisRepoTask.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.CodeScanningVariantAnalysisRepoTask.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}
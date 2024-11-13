//HintName: G.CodeScanningClient.CodeScanningDeleteAnalysis.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningDeleteAnalysisArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int analysisId,
            ref string? confirmDelete);
        partial void PrepareCodeScanningDeleteAnalysisRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int analysisId,
            string? confirmDelete);
        partial void ProcessCodeScanningDeleteAnalysisResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningDeleteAnalysisResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete a code scanning analysis from a repository<br/>
        /// Deletes a specified code scanning analysis from a repository.<br/>
        /// You can delete one analysis at a time.<br/>
        /// To delete a series of analyses, start with the most recent analysis and work backwards.<br/>
        /// Conceptually, the process is similar to the undo function in a text editor.<br/>
        /// When you list the analyses for a repository,<br/>
        /// one or more will be identified as deletable in the response:<br/>
        /// ```<br/>
        /// "deletable": true<br/>
        /// ```<br/>
        /// An analysis is deletable when it's the most recent in a set of analyses.<br/>
        /// Typically, a repository will have multiple sets of analyses<br/>
        /// for each enabled code scanning tool,<br/>
        /// where a set is determined by a unique combination of analysis values:<br/>
        /// * `ref`<br/>
        /// * `tool`<br/>
        /// * `category`<br/>
        /// If you attempt to delete an analysis that is not the most recent in a set,<br/>
        /// you'll get a 400 response with the message:<br/>
        /// ```<br/>
        /// Analysis specified is not deletable.<br/>
        /// ```<br/>
        /// The response from a successful `DELETE` operation provides you with<br/>
        /// two alternative URLs for deleting the next analysis in the set:<br/>
        /// `next_analysis_url` and `confirm_delete_url`.<br/>
        /// Use the `next_analysis_url` URL if you want to avoid accidentally deleting the final analysis<br/>
        /// in a set. This is a useful option if you want to preserve at least one analysis<br/>
        /// for the specified tool in your repository.<br/>
        /// Use the `confirm_delete_url` URL if you are content to remove all analyses for a tool.<br/>
        /// When you delete the last analysis in a set, the value of `next_analysis_url` and `confirm_delete_url`<br/>
        /// in the 200 response is `null`.<br/>
        /// As an example of the deletion process,<br/>
        /// let's imagine that you added a workflow that configured a particular code scanning tool<br/>
        /// to analyze the code in a repository. This tool has added 15 analyses:<br/>
        /// 10 on the default branch, and another 5 on a topic branch.<br/>
        /// You therefore have two separate sets of analyses for this tool.<br/>
        /// You've now decided that you want to remove all of the analyses for the tool.<br/>
        /// To do this you must make 15 separate deletion requests.<br/>
        /// To start, you must find an analysis that's identified as deletable.<br/>
        /// Each set of analyses always has one that's identified as deletable.<br/>
        /// Having found the deletable analysis for one of the two sets,<br/>
        /// delete this analysis and then continue deleting the next analysis in the set until they're all deleted.<br/>
        /// Then repeat the process for the second set.<br/>
        /// The procedure therefore consists of a nested loop:<br/>
        /// **Outer loop**:<br/>
        /// * List the analyses for the repository, filtered by tool.<br/>
        /// * Parse this list to find a deletable analysis. If found:<br/>
        ///   **Inner loop**:<br/>
        ///   * Delete the identified analysis.<br/>
        ///   * Parse the response for the value of `confirm_delete_url` and, if found, use this in the next iteration.<br/>
        /// The above process assumes that you want to remove all trace of the tool's analyses from the GitHub user interface, for the specified repository, and it therefore uses the `confirm_delete_url` value. Alternatively, you could use the `next_analysis_url` value, which would leave the last analysis in each set undeleted to avoid removing a tool's analysis entirely.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="analysisId"></param>
        /// <param name="confirmDelete"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodeScanningAnalysisDeletion> CodeScanningDeleteAnalysisAsync(
            string owner,
            string repo,
            int analysisId,
            string? confirmDelete = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCodeScanningDeleteAnalysisArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                analysisId: ref analysisId,
                confirmDelete: ref confirmDelete);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/code-scanning/analyses/{analysisId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("confirm_delete", confirmDelete) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCodeScanningDeleteAnalysisRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                analysisId: analysisId,
                confirmDelete: confirmDelete);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodeScanningDeleteAnalysisResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::G.BasicError? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::G.BasicError.FromJson(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Response if the repository is archived or if GitHub Advanced Security is not enabled for this repository
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.BasicError? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.BasicError.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
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
                global::G.CodeScanningDeleteAnalysisResponse? __value_503 = null;
                if (ReadResponseAsString)
                {
                    __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = global::G.CodeScanningDeleteAnalysisResponse.FromJson(__content_503, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = await global::G.CodeScanningDeleteAnalysisResponse.FromJsonStreamAsync(__contentStream_503, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.CodeScanningDeleteAnalysisResponse>(
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
                ProcessCodeScanningDeleteAnalysisResponseContent(
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
                    global::G.CodeScanningAnalysisDeletion.FromJson(__content, JsonSerializerOptions) ??
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
                    await global::G.CodeScanningAnalysisDeletion.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}
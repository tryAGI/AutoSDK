//HintName: G.CodeScanningClient.CodeScanningUploadSarif.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningUploadSarifArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.CodeScanningUploadSarifRequest request);
        partial void PrepareCodeScanningUploadSarifRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.CodeScanningUploadSarifRequest request);
        partial void ProcessCodeScanningUploadSarifResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningUploadSarifResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload an analysis as SARIF data<br/>
        /// Uploads SARIF data containing the results of a code scanning analysis to make the results available in a repository. For troubleshooting information, see "[Troubleshooting SARIF uploads](https://docs.github.com/code-security/code-scanning/troubleshooting-sarif)."<br/>
        /// There are two places where you can upload code scanning results.<br/>
        ///  - If you upload to a pull request, for example `--ref refs/pull/42/merge` or `--ref refs/pull/42/head`, then the results appear as alerts in a pull request check. For more information, see "[Triaging code scanning alerts in pull requests](/code-security/secure-coding/triaging-code-scanning-alerts-in-pull-requests)."<br/>
        ///  - If you upload to a branch, for example `--ref refs/heads/my-branch`, then the results appear in the **Security** tab for your repository. For more information, see "[Managing code scanning alerts for your repository](/code-security/secure-coding/managing-code-scanning-alerts-for-your-repository#viewing-the-alerts-for-a-repository)."<br/>
        /// You must compress the SARIF-formatted analysis data that you want to upload, using `gzip`, and then encode it as a Base64 format string. For example:<br/>
        /// ```<br/>
        /// gzip -c analysis-data.sarif | base64 -w0<br/>
        /// ```<br/>
        /// SARIF upload supports a maximum number of entries per the following data objects, and an analysis will be rejected if any of these objects is above its maximum value. For some objects, there are additional values over which the entries will be ignored while keeping the most important entries whenever applicable.<br/>
        /// To get the most out of your analysis when it includes data above the supported limits, try to optimize the analysis configuration. For example, for the CodeQL tool, identify and remove the most noisy queries. For more information, see "[SARIF results exceed one or more limits](https://docs.github.com/code-security/code-scanning/troubleshooting-sarif/results-exceed-limit)."<br/>
        /// | **SARIF data**                   | **Maximum values** | **Additional limits**                                                            |<br/>
        /// |----------------------------------|:------------------:|----------------------------------------------------------------------------------|<br/>
        /// | Runs per file                    |         20         |                                                                                  |<br/>
        /// | Results per run                  |       25,000       | Only the top 5,000 results will be included, prioritized by severity.            |<br/>
        /// | Rules per run                    |       25,000       |                                                                                  |<br/>
        /// | Tool extensions per run          |        100         |                                                                                  |<br/>
        /// | Thread Flow Locations per result |       10,000       | Only the top 1,000 Thread Flow Locations will be included, using prioritization. |<br/>
        /// | Location per result	             |       1,000        | Only 100 locations will be included.                                             |<br/>
        /// | Tags per rule	                   |         20         | Only 10 tags will be included.                                                   |<br/>
        /// The `202 Accepted` response includes an `id` value.<br/>
        /// You can use this ID to check the status of the upload by using it in the `/sarifs/{sarif_id}` endpoint.<br/>
        /// For more information, see "[Get information about a SARIF upload](/rest/code-scanning/code-scanning#get-information-about-a-sarif-upload)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.<br/>
        /// This endpoint is limited to 1,000 requests per hour for each user or app installation calling it.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodeScanningSarifsReceipt> CodeScanningUploadSarifAsync(
            string owner,
            string repo,
            global::G.CodeScanningUploadSarifRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCodeScanningUploadSarifArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/code-scanning/sarifs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodeScanningUploadSarifRequest(
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
            ProcessCodeScanningUploadSarifResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodeScanningUploadSarifResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodeScanningSarifsReceipt?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload an analysis as SARIF data<br/>
        /// Uploads SARIF data containing the results of a code scanning analysis to make the results available in a repository. For troubleshooting information, see "[Troubleshooting SARIF uploads](https://docs.github.com/code-security/code-scanning/troubleshooting-sarif)."<br/>
        /// There are two places where you can upload code scanning results.<br/>
        ///  - If you upload to a pull request, for example `--ref refs/pull/42/merge` or `--ref refs/pull/42/head`, then the results appear as alerts in a pull request check. For more information, see "[Triaging code scanning alerts in pull requests](/code-security/secure-coding/triaging-code-scanning-alerts-in-pull-requests)."<br/>
        ///  - If you upload to a branch, for example `--ref refs/heads/my-branch`, then the results appear in the **Security** tab for your repository. For more information, see "[Managing code scanning alerts for your repository](/code-security/secure-coding/managing-code-scanning-alerts-for-your-repository#viewing-the-alerts-for-a-repository)."<br/>
        /// You must compress the SARIF-formatted analysis data that you want to upload, using `gzip`, and then encode it as a Base64 format string. For example:<br/>
        /// ```<br/>
        /// gzip -c analysis-data.sarif | base64 -w0<br/>
        /// ```<br/>
        /// SARIF upload supports a maximum number of entries per the following data objects, and an analysis will be rejected if any of these objects is above its maximum value. For some objects, there are additional values over which the entries will be ignored while keeping the most important entries whenever applicable.<br/>
        /// To get the most out of your analysis when it includes data above the supported limits, try to optimize the analysis configuration. For example, for the CodeQL tool, identify and remove the most noisy queries. For more information, see "[SARIF results exceed one or more limits](https://docs.github.com/code-security/code-scanning/troubleshooting-sarif/results-exceed-limit)."<br/>
        /// | **SARIF data**                   | **Maximum values** | **Additional limits**                                                            |<br/>
        /// |----------------------------------|:------------------:|----------------------------------------------------------------------------------|<br/>
        /// | Runs per file                    |         20         |                                                                                  |<br/>
        /// | Results per run                  |       25,000       | Only the top 5,000 results will be included, prioritized by severity.            |<br/>
        /// | Rules per run                    |       25,000       |                                                                                  |<br/>
        /// | Tool extensions per run          |        100         |                                                                                  |<br/>
        /// | Thread Flow Locations per result |       10,000       | Only the top 1,000 Thread Flow Locations will be included, using prioritization. |<br/>
        /// | Location per result	             |       1,000        | Only 100 locations will be included.                                             |<br/>
        /// | Tags per rule	                   |         20         | Only 10 tags will be included.                                                   |<br/>
        /// The `202 Accepted` response includes an `id` value.<br/>
        /// You can use this ID to check the status of the upload by using it in the `/sarifs/{sarif_id}` endpoint.<br/>
        /// For more information, see "[Get information about a SARIF upload](/rest/code-scanning/code-scanning#get-information-about-a-sarif-upload)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.<br/>
        /// This endpoint is limited to 1,000 requests per hour for each user or app installation calling it.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commitSha">
        /// The SHA of the commit to which the analysis you are uploading relates.
        /// </param>
        /// <param name="ref">
        /// The full Git reference, formatted as `refs/heads/&lt;branch name&gt;`,<br/>
        /// `refs/tags/&lt;tag&gt;`, `refs/pull/&lt;number&gt;/merge`, or `refs/pull/&lt;number&gt;/head`.<br/>
        /// Example: refs/heads/main
        /// </param>
        /// <param name="sarif">
        /// A Base64 string representing the SARIF file to upload. You must first compress your SARIF file using [`gzip`](http://www.gnu.org/software/gzip/manual/gzip.html) and then translate the contents of the file into a Base64 encoding string. For more information, see "[SARIF support for code scanning](https://docs.github.com/code-security/secure-coding/sarif-support-for-code-scanning)."
        /// </param>
        /// <param name="checkoutUri">
        /// The base directory used in the analysis, as it appears in the SARIF file.<br/>
        /// This property is used to convert file paths from absolute to relative, so that alerts can be mapped to their correct location in the repository.<br/>
        /// Example: file:///github/workspace/
        /// </param>
        /// <param name="startedAt">
        /// The time that the analysis run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="toolName">
        /// The name of the tool used to generate the code scanning analysis. If this parameter is not used, the tool name defaults to "API". If the uploaded SARIF contains a tool GUID, this will be available for filtering using the `tool_guid` parameter of operations such as `GET /repos/{owner}/{repo}/code-scanning/alerts`.
        /// </param>
        /// <param name="validate">
        /// Whether the SARIF file will be validated according to the code scanning specifications.<br/>
        /// This parameter is intended to help integrators ensure that the uploaded SARIF files are correctly rendered by code scanning.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodeScanningSarifsReceipt> CodeScanningUploadSarifAsync(
            string owner,
            string repo,
            string commitSha,
            string @ref,
            string sarif,
            string? checkoutUri = default,
            global::System.DateTime startedAt = default,
            string? toolName = default,
            bool validate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CodeScanningUploadSarifRequest
            {
                CommitSha = commitSha,
                Ref = @ref,
                Sarif = sarif,
                CheckoutUri = checkoutUri,
                StartedAt = startedAt,
                ToolName = toolName,
                Validate = validate,
            };

            return await CodeScanningUploadSarifAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
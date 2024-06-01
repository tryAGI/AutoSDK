//HintName: G.CodeScanningClient.CodeScanningUploadSarif.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        /// <summary>
        /// Upload an analysis as SARIF data
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CodeScanningSarifsReceipt> CodeScanningUploadSarifAsync(
            string owner,
            string repo,
            CodeScanningUploadSarifRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/code-scanning/sarifs", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<CodeScanningSarifsReceipt?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload an analysis as SARIF data
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commitSha"></param>
        /// <param name="@ref"></param>
        /// <param name="sarif"></param>
        /// <param name="checkoutUri"></param>
        /// <param name="startedAt"></param>
        /// <param name="toolName"></param>
        /// <param name="validate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CodeScanningSarifsReceipt> CodeScanningUploadSarifAsync(
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
            var request = new CodeScanningUploadSarifRequest
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
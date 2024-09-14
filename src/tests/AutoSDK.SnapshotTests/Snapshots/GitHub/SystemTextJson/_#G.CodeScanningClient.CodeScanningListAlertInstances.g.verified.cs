//HintName: G.CodeScanningClient.CodeScanningListAlertInstances.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningListAlertInstancesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int alertNumber,
            ref int page,
            ref int perPage,
            ref string? @ref);
        partial void PrepareCodeScanningListAlertInstancesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int alertNumber,
            int page,
            int perPage,
            string? @ref);
        partial void ProcessCodeScanningListAlertInstancesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningListAlertInstancesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List instances of a code scanning alert<br/>
        /// Lists all instances of the specified code scanning alert.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="ref">
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeScanningAlertInstance>> CodeScanningListAlertInstancesAsync(
            string owner,
            string repo,
            int alertNumber,
            int page = 1,
            int perPage = 30,
            string? @ref = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCodeScanningListAlertInstancesArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                alertNumber: ref alertNumber,
                page: ref page,
                perPage: ref perPage,
                @ref: ref @ref);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/code-scanning/alerts/{alertNumber}/instances?page={page}&per_page={perPage}&ref={@ref}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodeScanningListAlertInstancesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                page: page,
                perPage: perPage,
                @ref: @ref);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodeScanningListAlertInstancesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodeScanningListAlertInstancesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.CodeScanningAlertInstance>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}
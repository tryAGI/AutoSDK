//HintName: G.AdminClient.AdminSetAccountCPUPMOverride.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        partial void PrepareAdminSetAccountCPUPMOverrideArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? accountId,
            ref double cpupmOverride,
            global::System.DateTime endDate);
        partial void PrepareAdminSetAccountCPUPMOverrideRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? accountId,
            double cpupmOverride,
            global::System.DateTime endDate);
        partial void ProcessAdminSetAccountCPUPMOverrideResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAdminSetAccountCPUPMOverrideResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// SetAccountCPUPMOverride.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="cpupmOverride"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AdminSetAccountCPUPMOverrideResponse> AdminSetAccountCPUPMOverrideAsync(
            string? token,
            string? accountId,
            double cpupmOverride,
            global::System.DateTime endDate,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAdminSetAccountCPUPMOverrideArguments(
                httpClient: _httpClient,
                token: ref token,
                accountId: ref accountId,
                cpupmOverride: ref cpupmOverride,
                endDate: endDate);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/admin/setaccountcpupmoverride?accountId={accountId}&cpupmOverride={cpupmOverride}&endDate={endDate:yyyy-MM-ddTHH:mm:ssZ}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAdminSetAccountCPUPMOverrideRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                accountId: accountId,
                cpupmOverride: cpupmOverride,
                endDate: endDate);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAdminSetAccountCPUPMOverrideResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAdminSetAccountCPUPMOverrideResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.AdminSetAccountCPUPMOverrideResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}
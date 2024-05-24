//HintName: G.AdminClient.AdminSetAccountCPUPMOverride.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        /// <summary>
        /// SetAccountCPUPMOverride.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="cpupmOverride"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AdminSetAccountCPUPMOverrideAsync(
            string token,
            string accountId,
            double cpupmOverride,
            global::System.DateTime endDate,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/admin/setaccountcpupmoverride?accountId={accountId}&cpupmOverride={cpupmOverride}&endDate={endDate}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}
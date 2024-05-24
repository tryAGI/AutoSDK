//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesListGlobalAdvisories.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        /// <summary>
        /// List global security advisories
        /// </summary>
        /// <param name="ghsaId"></param>
        /// <param name="type"></param>
        /// <param name="cveId"></param>
        /// <param name="ecosystem"></param>
        /// <param name="severity"></param>
        /// <param name="cwes"></param>
        /// <param name="isWithdrawn"></param>
        /// <param name="affects"></param>
        /// <param name="published"></param>
        /// <param name="updated"></param>
        /// <param name="modified"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SecurityAdvisoriesListGlobalAdvisoriesAsync(
            string ghsaId,
            string type,
            string cveId,
            string ecosystem,
            string severity,
            object cwes,
            bool isWithdrawn,
            object affects,
            string published,
            string updated,
            string modified,
            string before,
            string after,
            string direction,
            int perPage,
            string sort,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/advisories?ghsa_id={ghsaId}&type={type}&cve_id={cveId}&ecosystem={ecosystem}&severity={severity}&cwes={cwes}&is_withdrawn={isWithdrawn}&affects={affects}&published={published}&updated={updated}&modified={modified}&before={before}&after={after}&direction={direction}&per_page={perPage}&sort={sort}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<GlobalAdvisory>> SecurityAdvisoriesListGlobalAdvisoriesAsync(
            string ghsaId,
            SecurityAdvisoriesListGlobalAdvisoriesType type,
            string cveId,
            SecurityAdvisoriesListGlobalAdvisoriesEcosystem ecosystem,
            SecurityAdvisoriesListGlobalAdvisoriesSeverity severity,
            global::System.OneOf<string, global::System.Collections.Generic.IList<string>> cwes,
            bool isWithdrawn,
            global::System.OneOf<string, global::System.Collections.Generic.IList<string>> affects,
            string published,
            string updated,
            string modified,
            string before,
            string after,
            SecurityAdvisoriesListGlobalAdvisoriesDirection direction,
            int perPage,
            SecurityAdvisoriesListGlobalAdvisoriesSort sort,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var typeValue = type switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesType.Reviewed => "reviewed",
                SecurityAdvisoriesListGlobalAdvisoriesType.Malware => "malware",
                SecurityAdvisoriesListGlobalAdvisoriesType.Unreviewed => "unreviewed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var ecosystemValue = ecosystem switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Rubygems => "rubygems",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Npm => "npm",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Pip => "pip",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Maven => "maven",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Nuget => "nuget",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Composer => "composer",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Go => "go",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Rust => "rust",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Erlang => "erlang",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Actions => "actions",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Pub => "pub",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Other => "other",
                SecurityAdvisoriesListGlobalAdvisoriesEcosystem.Swift => "swift",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var severityValue = severity switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Unknown => "unknown",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Low => "low",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Medium => "medium",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.High => "high",
                SecurityAdvisoriesListGlobalAdvisoriesSeverity.Critical => "critical",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesDirection.Asc => "asc",
                SecurityAdvisoriesListGlobalAdvisoriesDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                SecurityAdvisoriesListGlobalAdvisoriesSort.Updated => "updated",
                SecurityAdvisoriesListGlobalAdvisoriesSort.Published => "published",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/advisories?ghsa_id={ghsaId}&type={typeValue}&cve_id={cveId}&ecosystem={ecosystemValue}&severity={severityValue}&cwes={cwes}&is_withdrawn={isWithdrawn}&affects={affects}&published={published}&updated={updated}&modified={modified}&before={before}&after={after}&direction={directionValue}&per_page={perPage}&sort={sortValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<GlobalAdvisory>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}
//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesListGlobalAdvisories.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        partial void PrepareSecurityAdvisoriesListGlobalAdvisoriesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? ghsaId,
            ref global::G.SecurityAdvisoriesListGlobalAdvisoriesType? type,
            ref string? cveId,
            ref global::G.SecurityAdvisoryEcosystems? ecosystem,
            ref global::G.SecurityAdvisoriesListGlobalAdvisoriesSeverity? severity,
            ref global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? cwes,
            ref bool? isWithdrawn,
            ref global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? affects,
            ref string? published,
            ref string? updated,
            ref string? modified,
            ref string? epssPercentage,
            ref string? epssPercentile,
            ref string? before,
            ref string? after,
            ref global::G.SecurityAdvisoriesListGlobalAdvisoriesDirection? direction,
            ref int? perPage,
            ref global::G.SecurityAdvisoriesListGlobalAdvisoriesSort? sort);
        partial void PrepareSecurityAdvisoriesListGlobalAdvisoriesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? ghsaId,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesType? type,
            string? cveId,
            global::G.SecurityAdvisoryEcosystems? ecosystem,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesSeverity? severity,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? cwes,
            bool? isWithdrawn,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? affects,
            string? published,
            string? updated,
            string? modified,
            string? epssPercentage,
            string? epssPercentile,
            string? before,
            string? after,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesDirection? direction,
            int? perPage,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesSort? sort);
        partial void ProcessSecurityAdvisoriesListGlobalAdvisoriesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityAdvisoriesListGlobalAdvisoriesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List global security advisories<br/>
        /// Lists all global security advisories that match the specified parameters. If no other parameters are defined, the request will return only GitHub-reviewed advisories that are not malware.<br/>
        /// By default, all responses will exclude advisories for malware, because malware are not standard vulnerabilities. To list advisories for malware, you must include the `type` parameter in your request, with the value `malware`. For more information about the different types of security advisories, see "[About the GitHub Advisory database](https://docs.github.com/code-security/security-advisories/global-security-advisories/about-the-github-advisory-database#about-types-of-security-advisories)."
        /// </summary>
        /// <param name="ghsaId"></param>
        /// <param name="type">
        /// Default Value: reviewed
        /// </param>
        /// <param name="cveId"></param>
        /// <param name="ecosystem">
        /// The package's language or package management ecosystem.
        /// </param>
        /// <param name="severity"></param>
        /// <param name="cwes"></param>
        /// <param name="isWithdrawn"></param>
        /// <param name="affects"></param>
        /// <param name="published"></param>
        /// <param name="updated"></param>
        /// <param name="modified"></param>
        /// <param name="epssPercentage"></param>
        /// <param name="epssPercentile"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="sort">
        /// Default Value: published
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GlobalAdvisory>> SecurityAdvisoriesListGlobalAdvisoriesAsync(
            string? ghsaId = default,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesType? type = global::G.SecurityAdvisoriesListGlobalAdvisoriesType.Reviewed,
            string? cveId = default,
            global::G.SecurityAdvisoryEcosystems? ecosystem = default,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesSeverity? severity = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? cwes = default,
            bool? isWithdrawn = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? affects = default,
            string? published = default,
            string? updated = default,
            string? modified = default,
            string? epssPercentage = default,
            string? epssPercentile = default,
            string? before = default,
            string? after = default,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesDirection? direction = global::G.SecurityAdvisoriesListGlobalAdvisoriesDirection.Desc,
            int? perPage = 30,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesSort? sort = global::G.SecurityAdvisoriesListGlobalAdvisoriesSort.Published,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSecurityAdvisoriesListGlobalAdvisoriesArguments(
                httpClient: _httpClient,
                ghsaId: ref ghsaId,
                type: ref type,
                cveId: ref cveId,
                ecosystem: ref ecosystem,
                severity: ref severity,
                cwes: ref cwes,
                isWithdrawn: ref isWithdrawn,
                affects: ref affects,
                published: ref published,
                updated: ref updated,
                modified: ref modified,
                epssPercentage: ref epssPercentage,
                epssPercentile: ref epssPercentile,
                before: ref before,
                after: ref after,
                direction: ref direction,
                perPage: ref perPage,
                sort: ref sort);

            var __pathBuilder = new PathBuilder(
                path: "/advisories",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ghsa_id", ghsaId) 
                .AddOptionalParameter("type", type?.ToValueString()) 
                .AddOptionalParameter("cve_id", cveId) 
                .AddOptionalParameter("ecosystem", ecosystem?.ToValueString()) 
                .AddOptionalParameter("severity", severity?.ToValueString()) 
                .AddOptionalParameter("cwes", cwes?.ToString() ?? string.Empty) 
                .AddOptionalParameter("is_withdrawn", isWithdrawn?.ToString()) 
                .AddOptionalParameter("affects", affects?.ToString() ?? string.Empty) 
                .AddOptionalParameter("published", published) 
                .AddOptionalParameter("updated", updated) 
                .AddOptionalParameter("modified", modified) 
                .AddOptionalParameter("epss_percentage", epssPercentage) 
                .AddOptionalParameter("epss_percentile", epssPercentile) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecurityAdvisoriesListGlobalAdvisoriesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ghsaId: ghsaId,
                type: type,
                cveId: cveId,
                ecosystem: ecosystem,
                severity: severity,
                cwes: cwes,
                isWithdrawn: isWithdrawn,
                affects: affects,
                published: published,
                updated: updated,
                modified: modified,
                epssPercentage: epssPercentage,
                epssPercentile: epssPercentile,
                before: before,
                after: after,
                direction: direction,
                perPage: perPage,
                sort: sort);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecurityAdvisoriesListGlobalAdvisoriesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecurityAdvisoriesListGlobalAdvisoriesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.GlobalAdvisory>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}
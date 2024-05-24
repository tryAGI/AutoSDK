//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesUpdateRepositoryAdvisory.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        /// <summary>
        /// Update a repository security advisory
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryAdvisory> SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            RepositoryAdvisoryUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/security-advisories/{ghsaId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<RepositoryAdvisory>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Update a repository security advisory
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="summary"></param>
        /// <param name="description"></param>
        /// <param name="cveId"></param>
        /// <param name="vulnerabilities"></param>
        /// <param name="cweIds"></param>
        /// <param name="credits"></param>
        /// <param name="severity"></param>
        /// <param name="cvssVectorString"></param>
        /// <param name="state"></param>
        /// <param name="collaboratingUsers"></param>
        /// <param name="collaboratingTeams"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryAdvisory> SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            string? summary = default,
            string? description = default,
            string? cveId = default,
            global::System.Collections.Generic.IList<RepositoryAdvisoryUpdateVulnerabilities?>? vulnerabilities = default,
            global::System.Collections.Generic.IList<string?>? cweIds = default,
            global::System.Collections.Generic.IList<RepositoryAdvisoryUpdateCredits?>? credits = default,
            RepositoryAdvisoryUpdateSeverity? severity = default,
            string? cvssVectorString = default,
            RepositoryAdvisoryUpdateState? state = default,
            global::System.Collections.Generic.IList<string?>? collaboratingUsers = default,
            global::System.Collections.Generic.IList<string?>? collaboratingTeams = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new RepositoryAdvisoryUpdate
            {
                Summary = summary,
                Description = description,
                CveId = cveId,
                Vulnerabilities = vulnerabilities,
                CweIds = cweIds,
                Credits = credits,
                Severity = severity,
                CvssVectorString = cvssVectorString,
                State = state,
                CollaboratingUsers = collaboratingUsers,
                CollaboratingTeams = collaboratingTeams,
            };

            return await SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
                owner: owner,
                repo: repo,
                ghsaId: ghsaId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
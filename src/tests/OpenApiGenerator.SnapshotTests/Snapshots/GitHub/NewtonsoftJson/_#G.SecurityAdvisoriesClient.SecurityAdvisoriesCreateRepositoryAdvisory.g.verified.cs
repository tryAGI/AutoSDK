//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesCreateRepositoryAdvisory.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        /// <summary>
        /// Create a repository security advisory
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryAdvisory> SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            RepositoryAdvisoryCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/security-advisories", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<RepositoryAdvisory?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a repository security advisory
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="summary"></param>
        /// <param name="description"></param>
        /// <param name="cveId"></param>
        /// <param name="vulnerabilities"></param>
        /// <param name="cweIds"></param>
        /// <param name="credits"></param>
        /// <param name="severity"></param>
        /// <param name="cvssVectorString"></param>
        /// <param name="startPrivateFork"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryAdvisory> SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string summary,
            string description,
            global::System.Collections.Generic.IList<RepositoryAdvisoryCreateVulnerabilities> vulnerabilities,
            string? cveId = default,
            global::System.Collections.Generic.IList<string?>? cweIds = default,
            global::System.Collections.Generic.IList<RepositoryAdvisoryCreateCredits?>? credits = default,
            RepositoryAdvisoryCreateSeverity? severity = default,
            string? cvssVectorString = default,
            bool startPrivateFork = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new RepositoryAdvisoryCreate
            {
                Summary = summary,
                Description = description,
                CveId = cveId,
                Vulnerabilities = vulnerabilities,
                CweIds = cweIds,
                Credits = credits,
                Severity = severity,
                CvssVectorString = cvssVectorString,
                StartPrivateFork = startPrivateFork,
            };

            return await SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
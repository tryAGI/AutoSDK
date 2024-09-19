//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesUpdateRepositoryAdvisory.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        partial void PrepareSecurityAdvisoriesUpdateRepositoryAdvisoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string ghsaId,
            global::G.RepositoryAdvisoryUpdate request);
        partial void PrepareSecurityAdvisoriesUpdateRepositoryAdvisoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string ghsaId,
            global::G.RepositoryAdvisoryUpdate request);
        partial void ProcessSecurityAdvisoriesUpdateRepositoryAdvisoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityAdvisoriesUpdateRepositoryAdvisoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a repository security advisory<br/>
        /// Update a repository security advisory using its GitHub Security Advisory (GHSA) identifier.<br/>
        /// In order to update any security advisory, the authenticated user must be a security manager or administrator of that repository,<br/>
        /// or a collaborator on the repository security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            global::G.RepositoryAdvisoryUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSecurityAdvisoriesUpdateRepositoryAdvisoryArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                ghsaId: ref ghsaId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/security-advisories/{ghsaId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecurityAdvisoriesUpdateRepositoryAdvisoryRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                ghsaId: ghsaId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecurityAdvisoriesUpdateRepositoryAdvisoryResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecurityAdvisoriesUpdateRepositoryAdvisoryResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryAdvisory?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a repository security advisory<br/>
        /// Update a repository security advisory using its GitHub Security Advisory (GHSA) identifier.<br/>
        /// In order to update any security advisory, the authenticated user must be a security manager or administrator of that repository,<br/>
        /// or a collaborator on the repository security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="summary">
        /// A short summary of the advisory.
        /// </param>
        /// <param name="description">
        /// A detailed description of what the advisory impacts.
        /// </param>
        /// <param name="cveId">
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </param>
        /// <param name="vulnerabilities">
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </param>
        /// <param name="cweIds">
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </param>
        /// <param name="credits">
        /// A list of users receiving credit for their participation in the security advisory.
        /// </param>
        /// <param name="severity">
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </param>
        /// <param name="cvssVectorString">
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </param>
        /// <param name="state">
        /// The state of the advisory.
        /// </param>
        /// <param name="collaboratingUsers">
        /// A list of usernames who have been granted write access to the advisory.
        /// </param>
        /// <param name="collaboratingTeams">
        /// A list of team slugs which have been granted write access to the advisory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            string? summary = default,
            string? description = default,
            string? cveId = default,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateVulnerabilitie>? vulnerabilities = default,
            global::System.Collections.Generic.IList<string>? cweIds = default,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateCredit>? credits = default,
            global::G.RepositoryAdvisoryUpdateSeverity? severity = default,
            string? cvssVectorString = default,
            global::G.RepositoryAdvisoryUpdateState? state = default,
            global::System.Collections.Generic.IList<string>? collaboratingUsers = default,
            global::System.Collections.Generic.IList<string>? collaboratingTeams = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.RepositoryAdvisoryUpdate
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
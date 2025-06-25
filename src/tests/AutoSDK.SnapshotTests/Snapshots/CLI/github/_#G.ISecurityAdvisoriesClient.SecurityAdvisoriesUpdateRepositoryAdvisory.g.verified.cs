//HintName: G.ISecurityAdvisoriesClient.SecurityAdvisoriesUpdateRepositoryAdvisory.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityAdvisoriesClient
    {
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            global::G.RepositoryAdvisoryUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
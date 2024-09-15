//HintName: G.ISecurityAdvisoriesClient.SecurityAdvisoriesCreateRepositoryAdvisory.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// Create a repository security advisory<br/>
        /// Creates a new repository security advisory.<br/>
        /// In order to create a draft repository security advisory, the authenticated user must be a security manager or administrator of that repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            global::G.RepositoryAdvisoryCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a repository security advisory<br/>
        /// Creates a new repository security advisory.<br/>
        /// In order to create a draft repository security advisory, the authenticated user must be a security manager or administrator of that repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
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
        /// <param name="startPrivateFork">
        /// Whether to create a temporary private fork of the repository to collaborate on a fix.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string summary,
            string description,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateVulnerabilitie> vulnerabilities,
            string? cveId = default,
            global::System.Collections.Generic.IList<string>? cweIds = default,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateCredit>? credits = default,
            global::G.RepositoryAdvisoryCreateSeverity? severity = default,
            string? cvssVectorString = default,
            bool startPrivateFork = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
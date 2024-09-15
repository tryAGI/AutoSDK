//HintName: G.ISecurityAdvisoriesClient.SecurityAdvisoriesListGlobalAdvisories.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityAdvisoriesClient
    {
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GlobalAdvisory>> SecurityAdvisoriesListGlobalAdvisoriesAsync(
            string? ghsaId = default,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesType? type = global::G.SecurityAdvisoriesListGlobalAdvisoriesType.Reviewed,
            string? cveId = default,
            global::G.SecurityAdvisoryEcosystems? ecosystem = default,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesSeverity? severity = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? cwes = default,
            bool isWithdrawn = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? affects = default,
            string? published = default,
            string? updated = default,
            string? modified = default,
            string? before = default,
            string? after = default,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesDirection? direction = global::G.SecurityAdvisoriesListGlobalAdvisoriesDirection.Desc,
            int perPage = 30,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesSort? sort = global::G.SecurityAdvisoriesListGlobalAdvisoriesSort.Published,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
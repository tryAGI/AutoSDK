﻿//HintName: G.IReposClient.ReposGetOrgRuleSuites.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List organization rule suites<br/>
        /// Lists suites of rule evaluations at the organization level.<br/>
        /// For more information, see "[Managing rulesets for repositories in your organization](https://docs.github.com/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="ref"></param>
        /// <param name="repositoryName"></param>
        /// <param name="timePeriod">
        /// Default Value: day
        /// </param>
        /// <param name="actorName"></param>
        /// <param name="ruleSuiteResult">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RuleSuite>> ReposGetOrgRuleSuitesAsync(
            string org,
            string? @ref = default,
            int? repositoryName = default,
            global::G.ReposGetOrgRuleSuitesTimePeriod? timePeriod = default,
            string? actorName = default,
            global::G.ReposGetOrgRuleSuitesRuleSuiteResult? ruleSuiteResult = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
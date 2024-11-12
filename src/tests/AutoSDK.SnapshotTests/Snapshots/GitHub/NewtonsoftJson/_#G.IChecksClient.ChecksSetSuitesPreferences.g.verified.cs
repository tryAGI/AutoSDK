//HintName: G.IChecksClient.ChecksSetSuitesPreferences.g.cs
#nullable enable

namespace G
{
    public partial interface IChecksClient
    {
        /// <summary>
        /// Update repository preferences for check suites<br/>
        /// Changes the default automatic flow when creating check suites. By default, a check suite is automatically created each time code is pushed to a repository. When you disable the automatic creation of check suites, you can manually [Create a check suite](https://docs.github.com/rest/checks/suites#create-a-check-suite).<br/>
        /// You must have admin permissions in the repository to set preferences for check suites.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckSuitePreference> ChecksSetSuitesPreferencesAsync(
            string owner,
            string repo,
            global::G.ChecksSetSuitesPreferencesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update repository preferences for check suites<br/>
        /// Changes the default automatic flow when creating check suites. By default, a check suite is automatically created each time code is pushed to a repository. When you disable the automatic creation of check suites, you can manually [Create a check suite](https://docs.github.com/rest/checks/suites#create-a-check-suite).<br/>
        /// You must have admin permissions in the repository to set preferences for check suites.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="autoTriggerChecks">
        /// Enables or disables automatic creation of CheckSuite events upon pushes to the repository. Enabled by default.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckSuitePreference> ChecksSetSuitesPreferencesAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::G.ChecksSetSuitesPreferencesRequestAutoTriggerCheck>? autoTriggerChecks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
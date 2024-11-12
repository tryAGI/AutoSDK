//HintName: G.ICodeSecurityClient.CodeSecurityUpdateConfiguration.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Update a code security configuration<br/>
        /// Updates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeSecurityConfiguration> CodeSecurityUpdateConfigurationAsync(
            string org,
            int configurationId,
            global::G.CodeSecurityUpdateConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a code security configuration<br/>
        /// Updates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non-provider patterns
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeSecurityConfiguration> CodeSecurityUpdateConfigurationAsync(
            string org,
            int configurationId,
            string? name = default,
            string? description = default,
            global::G.CodeSecurityUpdateConfigurationRequestAdvancedSecurity? advancedSecurity = default,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraph? dependencyGraph = default,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction = default,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions = default,
            global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts? dependabotAlerts = default,
            global::G.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates = default,
            global::G.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup = default,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanning? secretScanning = default,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection = default,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks = default,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns = default,
            global::G.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting = default,
            global::G.CodeSecurityUpdateConfigurationRequestEnforcement? enforcement = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
//HintName: G.ICodeSecurityClient.CodeSecurityCreateConfiguration.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Create a code security configuration<br/>
        /// Creates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeSecurityConfiguration> CodeSecurityCreateConfigurationAsync(
            string org,
            global::G.CodeSecurityCreateConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a code security configuration<br/>
        /// Creates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeSecurityConfiguration> CodeSecurityCreateConfigurationAsync(
            string org,
            string name,
            string description,
            global::G.CodeSecurityCreateConfigurationRequestAdvancedSecurity? advancedSecurity = default,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraph? dependencyGraph = default,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction = default,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions = default,
            global::G.CodeSecurityCreateConfigurationRequestDependabotAlerts? dependabotAlerts = default,
            global::G.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates = default,
            global::G.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup = default,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanning? secretScanning = default,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection = default,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks = default,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns = default,
            global::G.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting = default,
            global::G.CodeSecurityCreateConfigurationRequestEnforcement? enforcement = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
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
            global::G.CodeSecurityCreateConfigurationRequestAdvancedSecurity? advancedSecurity = global::G.CodeSecurityCreateConfigurationRequestAdvancedSecurity.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraph? dependencyGraph = global::G.CodeSecurityCreateConfigurationRequestDependencyGraph.Enabled,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction = global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions = default,
            global::G.CodeSecurityCreateConfigurationRequestDependabotAlerts? dependabotAlerts = global::G.CodeSecurityCreateConfigurationRequestDependabotAlerts.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates = global::G.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup = global::G.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanning? secretScanning = global::G.CodeSecurityCreateConfigurationRequestSecretScanning.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection = global::G.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks = global::G.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns = global::G.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting = global::G.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting.Disabled,
            global::G.CodeSecurityCreateConfigurationRequestEnforcement? enforcement = global::G.CodeSecurityCreateConfigurationRequestEnforcement.Enforced,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
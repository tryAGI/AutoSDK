//HintName: G.Commands.CodeSecurityUpdateConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeSecurityUpdateConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int configurationId,
            string? name,
            string? description,
            global::G.CodeSecurityUpdateConfigurationRequestAdvancedSecurity? advancedSecurity,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraph? dependencyGraph,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts? dependabotAlerts,
            global::G.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::G.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanning? secretScanning,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks,
            global::G.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::G.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::G.CodeSecurityUpdateConfigurationRequestEnforcement? enforcement,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodeSecurityConfiguration response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> ConfigurationId { get; } = new(
            name: "configurationId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestAdvancedSecurity?> AdvancedSecurity { get; } = new(
            name: "advancedSecurity")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestDependencyGraph?> DependencyGraph { get; } = new(
            name: "dependencyGraph")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction?> DependencyGraphAutosubmitAction { get; } = new(
            name: "dependencyGraphAutosubmitAction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions?> DependencyGraphAutosubmitActionOptions { get; } = new(
            name: "dependencyGraphAutosubmitActionOptions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts?> DependabotAlerts { get; } = new(
            name: "dependabotAlerts")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates?> DependabotSecurityUpdates { get; } = new(
            name: "dependabotSecurityUpdates")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup?> CodeScanningDefaultSetup { get; } = new(
            name: "codeScanningDefaultSetup")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestSecretScanning?> SecretScanning { get; } = new(
            name: "secretScanning")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection?> SecretScanningPushProtection { get; } = new(
            name: "secretScanningPushProtection")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks?> SecretScanningValidityChecks { get; } = new(
            name: "secretScanningValidityChecks")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns?> SecretScanningNonProviderPatterns { get; } = new(
            name: "secretScanningNonProviderPatterns")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReporting?> PrivateVulnerabilityReporting { get; } = new(
            name: "privateVulnerabilityReporting")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityUpdateConfigurationRequestEnforcement?> Enforcement { get; } = new(
            name: "enforcement")
        {
            Description = "",
        };
        public CodeSecurityUpdateConfigurationCommand(G.IApi client) : base(
            name: "code",
            description: @"Updates a code security configuration in an organization.

The authenticated user must be an administrator or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(ConfigurationId);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(AdvancedSecurity);
            Options.Add(DependencyGraph);
            Options.Add(DependencyGraphAutosubmitAction);
            Options.Add(DependencyGraphAutosubmitActionOptions);
            Options.Add(DependabotAlerts);
            Options.Add(DependabotSecurityUpdates);
            Options.Add(CodeScanningDefaultSetup);
            Options.Add(SecretScanning);
            Options.Add(SecretScanningPushProtection);
            Options.Add(SecretScanningValidityChecks);
            Options.Add(SecretScanningNonProviderPatterns);
            Options.Add(PrivateVulnerabilityReporting);
            Options.Add(Enforcement);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var configurationId = parseResult.GetRequiredValue(ConfigurationId);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var advancedSecurity = parseResult.GetRequiredValue(AdvancedSecurity);
            var dependencyGraph = parseResult.GetRequiredValue(DependencyGraph);
            var dependencyGraphAutosubmitAction = parseResult.GetRequiredValue(DependencyGraphAutosubmitAction);
            var dependencyGraphAutosubmitActionOptions = parseResult.GetRequiredValue(DependencyGraphAutosubmitActionOptions);
            var dependabotAlerts = parseResult.GetRequiredValue(DependabotAlerts);
            var dependabotSecurityUpdates = parseResult.GetRequiredValue(DependabotSecurityUpdates);
            var codeScanningDefaultSetup = parseResult.GetRequiredValue(CodeScanningDefaultSetup);
            var secretScanning = parseResult.GetRequiredValue(SecretScanning);
            var secretScanningPushProtection = parseResult.GetRequiredValue(SecretScanningPushProtection);
            var secretScanningValidityChecks = parseResult.GetRequiredValue(SecretScanningValidityChecks);
            var secretScanningNonProviderPatterns = parseResult.GetRequiredValue(SecretScanningNonProviderPatterns);
            var privateVulnerabilityReporting = parseResult.GetRequiredValue(PrivateVulnerabilityReporting);
            var enforcement = parseResult.GetRequiredValue(Enforcement);

            Validate(
                parseResult: parseResult,
                org: org,
                configurationId: configurationId,
                name: name,
                description: description,
                advancedSecurity: advancedSecurity,
                dependencyGraph: dependencyGraph,
                dependencyGraphAutosubmitAction: dependencyGraphAutosubmitAction,
                dependencyGraphAutosubmitActionOptions: dependencyGraphAutosubmitActionOptions,
                dependabotAlerts: dependabotAlerts,
                dependabotSecurityUpdates: dependabotSecurityUpdates,
                codeScanningDefaultSetup: codeScanningDefaultSetup,
                secretScanning: secretScanning,
                secretScanningPushProtection: secretScanningPushProtection,
                secretScanningValidityChecks: secretScanningValidityChecks,
                secretScanningNonProviderPatterns: secretScanningNonProviderPatterns,
                privateVulnerabilityReporting: privateVulnerabilityReporting,
                enforcement: enforcement,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeSecurity.CodeSecurityUpdateConfigurationAsync(
                org: org,
                configurationId: configurationId,
                name: name,
                description: description,
                advancedSecurity: advancedSecurity,
                dependencyGraph: dependencyGraph,
                dependencyGraphAutosubmitAction: dependencyGraphAutosubmitAction,
                dependencyGraphAutosubmitActionOptions: dependencyGraphAutosubmitActionOptions,
                dependabotAlerts: dependabotAlerts,
                dependabotSecurityUpdates: dependabotSecurityUpdates,
                codeScanningDefaultSetup: codeScanningDefaultSetup,
                secretScanning: secretScanning,
                secretScanningPushProtection: secretScanningPushProtection,
                secretScanningValidityChecks: secretScanningValidityChecks,
                secretScanningNonProviderPatterns: secretScanningNonProviderPatterns,
                privateVulnerabilityReporting: privateVulnerabilityReporting,
                enforcement: enforcement,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
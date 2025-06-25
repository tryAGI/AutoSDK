//HintName: G.Commands.CodeSecurityCreateConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeSecurityCreateConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string name,
            string description,
            global::G.CodeSecurityCreateConfigurationRequestAdvancedSecurity? advancedSecurity,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraph? dependencyGraph,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::G.CodeSecurityCreateConfigurationRequestDependabotAlerts? dependabotAlerts,
            global::G.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::G.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanning? secretScanning,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks,
            global::G.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::G.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::G.CodeSecurityCreateConfigurationRequestEnforcement? enforcement,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestAdvancedSecurity?> AdvancedSecurity { get; } = new(
            name: "advancedSecurity")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestDependencyGraph?> DependencyGraph { get; } = new(
            name: "dependencyGraph")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction?> DependencyGraphAutosubmitAction { get; } = new(
            name: "dependencyGraphAutosubmitAction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions?> DependencyGraphAutosubmitActionOptions { get; } = new(
            name: "dependencyGraphAutosubmitActionOptions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestDependabotAlerts?> DependabotAlerts { get; } = new(
            name: "dependabotAlerts")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates?> DependabotSecurityUpdates { get; } = new(
            name: "dependabotSecurityUpdates")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup?> CodeScanningDefaultSetup { get; } = new(
            name: "codeScanningDefaultSetup")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestSecretScanning?> SecretScanning { get; } = new(
            name: "secretScanning")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection?> SecretScanningPushProtection { get; } = new(
            name: "secretScanningPushProtection")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks?> SecretScanningValidityChecks { get; } = new(
            name: "secretScanningValidityChecks")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns?> SecretScanningNonProviderPatterns { get; } = new(
            name: "secretScanningNonProviderPatterns")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting?> PrivateVulnerabilityReporting { get; } = new(
            name: "privateVulnerabilityReporting")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeSecurityCreateConfigurationRequestEnforcement?> Enforcement { get; } = new(
            name: "enforcement")
        {
            Description = "",
        };
        public CodeSecurityCreateConfigurationCommand(G.IApi client) : base(
            name: "code",
            description: @"Creates a code security configuration in an organization.

The authenticated user must be an administrator or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Name);
            Arguments.Add(Description);
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
            var response = await _client.CodeSecurity.CodeSecurityCreateConfigurationAsync(
                org: org,
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
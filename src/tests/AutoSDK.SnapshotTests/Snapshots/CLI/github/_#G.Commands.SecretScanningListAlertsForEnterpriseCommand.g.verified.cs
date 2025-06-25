//HintName: G.Commands.SecretScanningListAlertsForEnterpriseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecretScanningListAlertsForEnterpriseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string enterprise,
            global::G.SecretScanningListAlertsForEnterpriseState? state,
            string? secretType,
            string? resolution,
            global::G.SecretScanningListAlertsForEnterpriseSort? sort,
            global::G.SecretScanningListAlertsForEnterpriseDirection? direction,
            int? perPage,
            string? before,
            string? after,
            string? validity,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.OrganizationSecretScanningAlert> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Enterprise { get; } = new(
            name: "enterprise")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForEnterpriseState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SecretType { get; } = new(
            name: "secretType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Resolution { get; } = new(
            name: "resolution")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForEnterpriseSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForEnterpriseDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Validity { get; } = new(
            name: "validity")
        {
            Description = "",
        };
        public SecretScanningListAlertsForEnterpriseCommand(G.IApi client) : base(
            name: "secret",
            description: @"Lists secret scanning alerts for eligible repositories in an enterprise, from newest to oldest.

Alerts are only returned for organizations in the enterprise for which the authenticated user is an organization owner or a [security manager](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).

The authenticated user must be a member of the enterprise in order to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope or `security_events` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Enterprise);
            Options.Add(State);
            Options.Add(SecretType);
            Options.Add(Resolution);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(PerPage);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Validity);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var enterprise = parseResult.GetRequiredValue(Enterprise);
            var state = parseResult.GetRequiredValue(State);
            var secretType = parseResult.GetRequiredValue(SecretType);
            var resolution = parseResult.GetRequiredValue(Resolution);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var validity = parseResult.GetRequiredValue(Validity);

            Validate(
                parseResult: parseResult,
                enterprise: enterprise,
                state: state,
                secretType: secretType,
                resolution: resolution,
                sort: sort,
                direction: direction,
                perPage: perPage,
                before: before,
                after: after,
                validity: validity,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecretScanning.SecretScanningListAlertsForEnterpriseAsync(
                enterprise: enterprise,
                state: state,
                secretType: secretType,
                resolution: resolution,
                sort: sort,
                direction: direction,
                perPage: perPage,
                before: before,
                after: after,
                validity: validity,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
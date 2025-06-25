//HintName: G.Commands.SecretScanningListAlertsForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecretScanningListAlertsForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.SecretScanningListAlertsForOrgState? state,
            string? secretType,
            string? resolution,
            global::G.SecretScanningListAlertsForOrgSort? sort,
            global::G.SecretScanningListAlertsForOrgDirection? direction,
            int? page,
            int? perPage,
            string? before,
            string? after,
            string? validity,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.OrganizationSecretScanningAlert> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForOrgState?> State { get; } = new(
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

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForOrgSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForOrgDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
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
        public SecretScanningListAlertsForOrgCommand(G.IApi client) : base(
            name: "secret",
            description: @"Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest.

The authenticated user must be an administrator or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(State);
            Options.Add(SecretType);
            Options.Add(Resolution);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(Page);
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
            var org = parseResult.GetRequiredValue(Org);
            var state = parseResult.GetRequiredValue(State);
            var secretType = parseResult.GetRequiredValue(SecretType);
            var resolution = parseResult.GetRequiredValue(Resolution);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var validity = parseResult.GetRequiredValue(Validity);

            Validate(
                parseResult: parseResult,
                org: org,
                state: state,
                secretType: secretType,
                resolution: resolution,
                sort: sort,
                direction: direction,
                page: page,
                perPage: perPage,
                before: before,
                after: after,
                validity: validity,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecretScanning.SecretScanningListAlertsForOrgAsync(
                org: org,
                state: state,
                secretType: secretType,
                resolution: resolution,
                sort: sort,
                direction: direction,
                page: page,
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
//HintName: G.Commands.SecretScanningListAlertsForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecretScanningListAlertsForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.SecretScanningListAlertsForRepoState? state,
            string? secretType,
            string? resolution,
            global::G.SecretScanningListAlertsForRepoSort? sort,
            global::G.SecretScanningListAlertsForRepoDirection? direction,
            int? page,
            int? perPage,
            string? before,
            string? after,
            string? validity,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.SecretScanningAlert> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForRepoState?> State { get; } = new(
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

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForRepoSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecretScanningListAlertsForRepoDirection?> Direction { get; } = new(
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
        public SecretScanningListAlertsForRepoCommand(G.IApi client) : base(
            name: "secret",
            description: @"Lists secret scanning alerts for an eligible repository, from newest to oldest.

The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
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
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
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
                owner: owner,
                repo: repo,
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
            var response = await _client.SecretScanning.SecretScanningListAlertsForRepoAsync(
                owner: owner,
                repo: repo,
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
//HintName: G.Commands.DependabotListAlertsForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependabotListAlertsForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            string? manifest,
            global::G.DependabotListAlertsForRepoScope? scope,
            global::G.DependabotListAlertsForRepoSort? sort,
            global::G.DependabotListAlertsForRepoDirection? direction,
            int? page,
            int? perPage,
            string? before,
            string? after,
            int? first,
            int? last,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.DependabotAlert> response,
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

        private global::System.CommandLine.Option<string?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Severity { get; } = new(
            name: "severity")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Ecosystem { get; } = new(
            name: "ecosystem")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Package { get; } = new(
            name: "package")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Manifest { get; } = new(
            name: "manifest")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForRepoScope?> Scope { get; } = new(
            name: "scope")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForRepoSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForRepoDirection?> Direction { get; } = new(
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

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Last { get; } = new(
            name: "last")
        {
            Description = "",
        };
        public DependabotListAlertsForRepoCommand(G.IApi client) : base(
            name: "dependabot",
            description: @"OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(State);
            Options.Add(Severity);
            Options.Add(Ecosystem);
            Options.Add(Package);
            Options.Add(Manifest);
            Options.Add(Scope);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(Page);
            Options.Add(PerPage);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(First);
            Options.Add(Last);

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
            var severity = parseResult.GetRequiredValue(Severity);
            var ecosystem = parseResult.GetRequiredValue(Ecosystem);
            var package = parseResult.GetRequiredValue(Package);
            var manifest = parseResult.GetRequiredValue(Manifest);
            var scope = parseResult.GetRequiredValue(Scope);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var first = parseResult.GetRequiredValue(First);
            var last = parseResult.GetRequiredValue(Last);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                manifest: manifest,
                scope: scope,
                sort: sort,
                direction: direction,
                page: page,
                perPage: perPage,
                before: before,
                after: after,
                first: first,
                last: last,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dependabot.DependabotListAlertsForRepoAsync(
                owner: owner,
                repo: repo,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                manifest: manifest,
                scope: scope,
                sort: sort,
                direction: direction,
                page: page,
                perPage: perPage,
                before: before,
                after: after,
                first: first,
                last: last,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
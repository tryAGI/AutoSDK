//HintName: G.Commands.DependabotListAlertsForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependabotListAlertsForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            global::G.DependabotListAlertsForOrgScope? scope,
            global::G.DependabotListAlertsForOrgSort? sort,
            global::G.DependabotListAlertsForOrgDirection? direction,
            string? before,
            string? after,
            int? first,
            int? last,
            int? perPage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
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

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForOrgScope?> Scope { get; } = new(
            name: "scope")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForOrgSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForOrgDirection?> Direction { get; } = new(
            name: "direction")
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

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };
        public DependabotListAlertsForOrgCommand(G.IApi client) : base(
            name: "dependabot",
            description: @"Lists Dependabot alerts for an organization.

The authenticated user must be an owner or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(State);
            Options.Add(Severity);
            Options.Add(Ecosystem);
            Options.Add(Package);
            Options.Add(Scope);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(First);
            Options.Add(Last);
            Options.Add(PerPage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var state = parseResult.GetRequiredValue(State);
            var severity = parseResult.GetRequiredValue(Severity);
            var ecosystem = parseResult.GetRequiredValue(Ecosystem);
            var package = parseResult.GetRequiredValue(Package);
            var scope = parseResult.GetRequiredValue(Scope);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var first = parseResult.GetRequiredValue(First);
            var last = parseResult.GetRequiredValue(Last);
            var perPage = parseResult.GetRequiredValue(PerPage);

            Validate(
                parseResult: parseResult,
                org: org,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                scope: scope,
                sort: sort,
                direction: direction,
                before: before,
                after: after,
                first: first,
                last: last,
                perPage: perPage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dependabot.DependabotListAlertsForOrgAsync(
                org: org,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                scope: scope,
                sort: sort,
                direction: direction,
                before: before,
                after: after,
                first: first,
                last: last,
                perPage: perPage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
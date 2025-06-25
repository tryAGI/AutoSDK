//HintName: G.Commands.DependabotListAlertsForEnterpriseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependabotListAlertsForEnterpriseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string enterprise,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            global::G.DependabotListAlertsForEnterpriseScope? scope,
            global::G.DependabotListAlertsForEnterpriseSort? sort,
            global::G.DependabotListAlertsForEnterpriseDirection? direction,
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

        private global::System.CommandLine.Argument<string> Enterprise { get; } = new(
            name: "enterprise")
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

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForEnterpriseScope?> Scope { get; } = new(
            name: "scope")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForEnterpriseSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DependabotListAlertsForEnterpriseDirection?> Direction { get; } = new(
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
        public DependabotListAlertsForEnterpriseCommand(G.IApi client) : base(
            name: "dependabot",
            description: @"Lists Dependabot alerts for repositories that are owned by the specified enterprise.

The authenticated user must be a member of the enterprise to use this endpoint.

Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see ""[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).""

OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Enterprise);
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
            var enterprise = parseResult.GetRequiredValue(Enterprise);
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
                enterprise: enterprise,
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
            var response = await _client.Dependabot.DependabotListAlertsForEnterpriseAsync(
                enterprise: enterprise,
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
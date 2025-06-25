//HintName: G.Commands.CodeScanningListAlertsForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningListAlertsForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string? toolName,
            string? toolGuid,
            string? before,
            string? after,
            int? page,
            int? perPage,
            global::G.CodeScanningListAlertsForOrgDirection? direction,
            global::G.CodeScanningAlertStateQuery? state,
            global::G.CodeScanningListAlertsForOrgSort? sort,
            global::G.CodeScanningAlertSeverity? severity,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CodeScanningOrganizationAlertItems> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ToolName { get; } = new(
            name: "toolName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ToolGuid { get; } = new(
            name: "toolGuid")
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

        private global::System.CommandLine.Option<global::G.CodeScanningListAlertsForOrgDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningAlertStateQuery?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningListAlertsForOrgSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningAlertSeverity?> Severity { get; } = new(
            name: "severity")
        {
            Description = "",
        };
        public CodeScanningListAlertsForOrgCommand(G.IApi client) : base(
            name: "code",
            description: @"Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see ""[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).""

The authenticated user must be an owner or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `security_events` or `repo`s cope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(ToolName);
            Options.Add(ToolGuid);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Page);
            Options.Add(PerPage);
            Options.Add(Direction);
            Options.Add(State);
            Options.Add(Sort);
            Options.Add(Severity);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var toolName = parseResult.GetRequiredValue(ToolName);
            var toolGuid = parseResult.GetRequiredValue(ToolGuid);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var direction = parseResult.GetRequiredValue(Direction);
            var state = parseResult.GetRequiredValue(State);
            var sort = parseResult.GetRequiredValue(Sort);
            var severity = parseResult.GetRequiredValue(Severity);

            Validate(
                parseResult: parseResult,
                org: org,
                toolName: toolName,
                toolGuid: toolGuid,
                before: before,
                after: after,
                page: page,
                perPage: perPage,
                direction: direction,
                state: state,
                sort: sort,
                severity: severity,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningListAlertsForOrgAsync(
                org: org,
                toolName: toolName,
                toolGuid: toolGuid,
                before: before,
                after: after,
                page: page,
                perPage: perPage,
                direction: direction,
                state: state,
                sort: sort,
                severity: severity,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.CodeScanningListAlertsForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningListAlertsForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? toolName,
            string? toolGuid,
            int? page,
            int? perPage,
            string? @ref,
            int? pr,
            global::G.CodeScanningListAlertsForRepoDirection? direction,
            string? before,
            string? after,
            global::G.CodeScanningListAlertsForRepoSort? sort,
            global::G.CodeScanningAlertStateQuery? state,
            global::G.CodeScanningAlertSeverity? severity,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CodeScanningAlertItems> response,
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

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Pr { get; } = new(
            name: "pr")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningListAlertsForRepoDirection?> Direction { get; } = new(
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

        private global::System.CommandLine.Option<global::G.CodeScanningListAlertsForRepoSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningAlertStateQuery?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningAlertSeverity?> Severity { get; } = new(
            name: "severity")
        {
            Description = "",
        };
        public CodeScanningListAlertsForRepoCommand(G.IApi client) : base(
            name: "code",
            description: @"Lists code scanning alerts.

The response includes a `most_recent_instance` object.
This provides details of the most recent instance of this alert
for the default branch (or for the specified Git reference if you used `ref` in the request).

OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(ToolName);
            Options.Add(ToolGuid);
            Options.Add(Page);
            Options.Add(PerPage);
            Options.Add(Ref);
            Options.Add(Pr);
            Options.Add(Direction);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Sort);
            Options.Add(State);
            Options.Add(Severity);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var toolName = parseResult.GetRequiredValue(ToolName);
            var toolGuid = parseResult.GetRequiredValue(ToolGuid);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var @ref = parseResult.GetRequiredValue(Ref);
            var pr = parseResult.GetRequiredValue(Pr);
            var direction = parseResult.GetRequiredValue(Direction);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var sort = parseResult.GetRequiredValue(Sort);
            var state = parseResult.GetRequiredValue(State);
            var severity = parseResult.GetRequiredValue(Severity);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                toolName: toolName,
                toolGuid: toolGuid,
                page: page,
                perPage: perPage,
                @ref: @ref,
                pr: pr,
                direction: direction,
                before: before,
                after: after,
                sort: sort,
                state: state,
                severity: severity,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningListAlertsForRepoAsync(
                owner: owner,
                repo: repo,
                toolName: toolName,
                toolGuid: toolGuid,
                page: page,
                perPage: perPage,
                @ref: @ref,
                pr: pr,
                direction: direction,
                before: before,
                after: after,
                sort: sort,
                state: state,
                severity: severity,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
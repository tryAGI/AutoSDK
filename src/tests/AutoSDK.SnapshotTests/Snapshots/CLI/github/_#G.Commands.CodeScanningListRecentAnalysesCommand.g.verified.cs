//HintName: G.Commands.CodeScanningListRecentAnalysesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningListRecentAnalysesCommand : global::System.CommandLine.Command
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
            int? pr,
            string? @ref,
            string? sarifId,
            global::G.CodeScanningListRecentAnalysesDirection? direction,
            global::G.CodeScanningListRecentAnalysesSort? sort,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CodeScanningAnalysis> response,
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

        private global::System.CommandLine.Option<int?> Pr { get; } = new(
            name: "pr")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SarifId { get; } = new(
            name: "sarifId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningListRecentAnalysesDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodeScanningListRecentAnalysesSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };
        public CodeScanningListRecentAnalysesCommand(G.IApi client) : base(
            name: "code",
            description: @"Lists the details of all code scanning analyses for a repository,
starting with the most recent.
The response is paginated and you can use the `page` and `per_page` parameters
to list the analyses you're interested in.
By default 30 analyses are listed per page.

The `rules_count` field in the response give the number of rules
that were run in the analysis.
For very old analyses this data is not available,
and `0` is returned in this field.

> [!WARNING]
> **Deprecation notice:** The `tool_name` field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the `tool` field.

OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(ToolName);
            Options.Add(ToolGuid);
            Options.Add(Page);
            Options.Add(PerPage);
            Options.Add(Pr);
            Options.Add(Ref);
            Options.Add(SarifId);
            Options.Add(Direction);
            Options.Add(Sort);

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
            var pr = parseResult.GetRequiredValue(Pr);
            var @ref = parseResult.GetRequiredValue(Ref);
            var sarifId = parseResult.GetRequiredValue(SarifId);
            var direction = parseResult.GetRequiredValue(Direction);
            var sort = parseResult.GetRequiredValue(Sort);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                toolName: toolName,
                toolGuid: toolGuid,
                page: page,
                perPage: perPage,
                pr: pr,
                @ref: @ref,
                sarifId: sarifId,
                direction: direction,
                sort: sort,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningListRecentAnalysesAsync(
                owner: owner,
                repo: repo,
                toolName: toolName,
                toolGuid: toolGuid,
                page: page,
                perPage: perPage,
                pr: pr,
                @ref: @ref,
                sarifId: sarifId,
                direction: direction,
                sort: sort,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
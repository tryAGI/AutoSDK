﻿//HintName: G.Commands.ActionsListWorkflowRunsForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsListWorkflowRunsForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? actor,
            string? branch,
            string? @event,
            global::G.ActionsListWorkflowRunsForRepoStatus? status,
            int? perPage,
            int? page,
            global::System.DateTime? created,
            bool? excludePullRequests,
            int? checkSuiteId,
            string? headSha,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsListWorkflowRunsForRepoResponse response,
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

        private global::System.CommandLine.Option<string?> Actor { get; } = new(
            name: "actor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Branch { get; } = new(
            name: "branch")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Event { get; } = new(
            name: "@event")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ActionsListWorkflowRunsForRepoStatus?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Created { get; } = new(
            name: "created")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ExcludePullRequests { get; } = new(
            name: "excludePullRequests")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> CheckSuiteId { get; } = new(
            name: "checkSuiteId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> HeadSha { get; } = new(
            name: "headSha")
        {
            Description = "",
        };
        public ActionsListWorkflowRunsForRepoCommand(G.IApi client) : base(
            name: "actions",
            description: @"Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#parameters).

Anyone with read access to the repository can use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.

This API will return up to 1,000 results for each search when using the following parameters: `actor`, `branch`, `check_suite_id`, `created`, `event`, `head_sha`, `status`.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Actor);
            Options.Add(Branch);
            Options.Add(Event);
            Options.Add(Status);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Created);
            Options.Add(ExcludePullRequests);
            Options.Add(CheckSuiteId);
            Options.Add(HeadSha);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var actor = parseResult.GetRequiredValue(Actor);
            var branch = parseResult.GetRequiredValue(Branch);
            var @event = parseResult.GetRequiredValue(Event);
            var status = parseResult.GetRequiredValue(Status);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var created = parseResult.GetRequiredValue(Created);
            var excludePullRequests = parseResult.GetRequiredValue(ExcludePullRequests);
            var checkSuiteId = parseResult.GetRequiredValue(CheckSuiteId);
            var headSha = parseResult.GetRequiredValue(HeadSha);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                actor: actor,
                branch: branch,
                @event: @event,
                status: status,
                perPage: perPage,
                page: page,
                created: created,
                excludePullRequests: excludePullRequests,
                checkSuiteId: checkSuiteId,
                headSha: headSha,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsListWorkflowRunsForRepoAsync(
                owner: owner,
                repo: repo,
                actor: actor,
                branch: branch,
                @event: @event,
                status: status,
                perPage: perPage,
                page: page,
                created: created,
                excludePullRequests: excludePullRequests,
                checkSuiteId: checkSuiteId,
                headSha: headSha,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
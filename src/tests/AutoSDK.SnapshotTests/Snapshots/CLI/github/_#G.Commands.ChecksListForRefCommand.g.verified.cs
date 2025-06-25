//HintName: G.Commands.ChecksListForRefCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChecksListForRefCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string @ref,
            string? checkName,
            global::G.ChecksListForRefStatus? status,
            global::G.ChecksListForRefFilter? filter,
            int? perPage,
            int? page,
            int? appId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ChecksListForRefResponse response,
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

        private global::System.CommandLine.Argument<string> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CheckName { get; } = new(
            name: "checkName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksListForRefStatus?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksListForRefFilter?> Filter { get; } = new(
            name: "filter")
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

        private global::System.CommandLine.Option<int?> AppId { get; } = new(
            name: "appId")
        {
            Description = "",
        };
        public ChecksListForRefCommand(G.IApi client) : base(
            name: "checks",
            description: @"Lists check runs for a commit ref. The `ref` can be a SHA, branch name, or a tag name.

> [!NOTE]
> The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.

If there are more than 1000 check suites on a single git reference, this endpoint will limit check runs to the 1000 most recent check suites. To iterate over all possible check runs, use the [List check suites for a Git reference](https://docs.github.com/rest/reference/checks#list-check-suites-for-a-git-reference) endpoint and provide the `check_suite_id` parameter to the [List check runs in a check suite](https://docs.github.com/rest/reference/checks#list-check-runs-in-a-check-suite) endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Ref);
            Options.Add(CheckName);
            Options.Add(Status);
            Options.Add(Filter);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(AppId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var @ref = parseResult.GetRequiredValue(Ref);
            var checkName = parseResult.GetRequiredValue(CheckName);
            var status = parseResult.GetRequiredValue(Status);
            var filter = parseResult.GetRequiredValue(Filter);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var appId = parseResult.GetRequiredValue(AppId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                @ref: @ref,
                checkName: checkName,
                status: status,
                filter: filter,
                perPage: perPage,
                page: page,
                appId: appId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Checks.ChecksListForRefAsync(
                owner: owner,
                repo: repo,
                @ref: @ref,
                checkName: checkName,
                status: status,
                filter: filter,
                perPage: perPage,
                page: page,
                appId: appId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
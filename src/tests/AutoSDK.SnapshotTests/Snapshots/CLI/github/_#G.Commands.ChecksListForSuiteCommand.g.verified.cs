//HintName: G.Commands.ChecksListForSuiteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChecksListForSuiteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int checkSuiteId,
            string? checkName,
            global::G.ChecksListForSuiteStatus? status,
            global::G.ChecksListForSuiteFilter? filter,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ChecksListForSuiteResponse response,
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

        private global::System.CommandLine.Argument<int> CheckSuiteId { get; } = new(
            name: "checkSuiteId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CheckName { get; } = new(
            name: "checkName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksListForSuiteStatus?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksListForSuiteFilter?> Filter { get; } = new(
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
        public ChecksListForSuiteCommand(G.IApi client) : base(
            name: "checks",
            description: @"Lists check runs for a check suite using its `id`.

> [!NOTE]
> The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CheckSuiteId);
            Options.Add(CheckName);
            Options.Add(Status);
            Options.Add(Filter);
            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var checkSuiteId = parseResult.GetRequiredValue(CheckSuiteId);
            var checkName = parseResult.GetRequiredValue(CheckName);
            var status = parseResult.GetRequiredValue(Status);
            var filter = parseResult.GetRequiredValue(Filter);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                checkSuiteId: checkSuiteId,
                checkName: checkName,
                status: status,
                filter: filter,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Checks.ChecksListForSuiteAsync(
                owner: owner,
                repo: repo,
                checkSuiteId: checkSuiteId,
                checkName: checkName,
                status: status,
                filter: filter,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
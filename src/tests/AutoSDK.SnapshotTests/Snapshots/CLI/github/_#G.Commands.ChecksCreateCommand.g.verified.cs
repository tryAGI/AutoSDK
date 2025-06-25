//HintName: G.Commands.ChecksCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChecksCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string name,
            string headSha,
            string? detailsUrl,
            string? externalId,
            global::G.ChecksCreateRequestStatus? status,
            global::System.DateTime? startedAt,
            global::G.ChecksCreateRequestConclusion? conclusion,
            global::System.DateTime? completedAt,
            global::G.ChecksCreateRequestOutput? output,
            global::System.Collections.Generic.IList<global::G.ChecksCreateRequestAction>? actions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CheckRun response,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> HeadSha { get; } = new(
            name: "headSha")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DetailsUrl { get; } = new(
            name: "detailsUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ExternalId { get; } = new(
            name: "externalId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksCreateRequestStatus?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartedAt { get; } = new(
            name: "startedAt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksCreateRequestConclusion?> Conclusion { get; } = new(
            name: "conclusion")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> CompletedAt { get; } = new(
            name: "completedAt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksCreateRequestOutput?> Output { get; } = new(
            name: "output")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChecksCreateRequestAction>?> Actions { get; } = new(
            name: "actions")
        {
            Description = "",
        };
        public ChecksCreateCommand(G.IApi client) : base(
            name: "checks",
            description: @"Creates a new check run for a specific commit in a repository.

To create a check run, you must use a GitHub App. OAuth apps and authenticated users are not able to create a check suite.

In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.

> [!NOTE]
> The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Name);
            Arguments.Add(HeadSha);
            Options.Add(DetailsUrl);
            Options.Add(ExternalId);
            Options.Add(Status);
            Options.Add(StartedAt);
            Options.Add(Conclusion);
            Options.Add(CompletedAt);
            Options.Add(Output);
            Options.Add(Actions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var name = parseResult.GetRequiredValue(Name);
            var headSha = parseResult.GetRequiredValue(HeadSha);
            var detailsUrl = parseResult.GetRequiredValue(DetailsUrl);
            var externalId = parseResult.GetRequiredValue(ExternalId);
            var status = parseResult.GetRequiredValue(Status);
            var startedAt = parseResult.GetRequiredValue(StartedAt);
            var conclusion = parseResult.GetRequiredValue(Conclusion);
            var completedAt = parseResult.GetRequiredValue(CompletedAt);
            var output = parseResult.GetRequiredValue(Output);
            var actions = parseResult.GetRequiredValue(Actions);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                name: name,
                headSha: headSha,
                detailsUrl: detailsUrl,
                externalId: externalId,
                status: status,
                startedAt: startedAt,
                conclusion: conclusion,
                completedAt: completedAt,
                output: output,
                actions: actions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Checks.ChecksCreateAsync(
                owner: owner,
                repo: repo,
                name: name,
                headSha: headSha,
                detailsUrl: detailsUrl,
                externalId: externalId,
                status: status,
                startedAt: startedAt,
                conclusion: conclusion,
                completedAt: completedAt,
                output: output,
                actions: actions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
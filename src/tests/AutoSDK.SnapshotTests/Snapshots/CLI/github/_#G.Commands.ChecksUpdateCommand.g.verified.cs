//HintName: G.Commands.ChecksUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChecksUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int checkRunId,
            string? name,
            string? detailsUrl,
            string? externalId,
            global::System.DateTime? startedAt,
            global::G.ChecksUpdateRequestStatus? status,
            global::G.ChecksUpdateRequestConclusion? conclusion,
            global::System.DateTime? completedAt,
            global::G.ChecksUpdateRequestOutput? output,
            global::System.Collections.Generic.IList<global::G.ChecksUpdateRequestAction>? actions,
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

        private global::System.CommandLine.Argument<int> CheckRunId { get; } = new(
            name: "checkRunId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
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

        private global::System.CommandLine.Option<global::System.DateTime?> StartedAt { get; } = new(
            name: "startedAt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksUpdateRequestStatus?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksUpdateRequestConclusion?> Conclusion { get; } = new(
            name: "conclusion")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> CompletedAt { get; } = new(
            name: "completedAt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChecksUpdateRequestOutput?> Output { get; } = new(
            name: "output")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChecksUpdateRequestAction>?> Actions { get; } = new(
            name: "actions")
        {
            Description = "",
        };
        public ChecksUpdateCommand(G.IApi client) : base(
            name: "checks",
            description: @"Updates a check run for a specific commit in a repository.

> [!NOTE]
> The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.

OAuth apps and personal access tokens (classic) cannot use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CheckRunId);
            Options.Add(Name);
            Options.Add(DetailsUrl);
            Options.Add(ExternalId);
            Options.Add(StartedAt);
            Options.Add(Status);
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
            var checkRunId = parseResult.GetRequiredValue(CheckRunId);
            var name = parseResult.GetRequiredValue(Name);
            var detailsUrl = parseResult.GetRequiredValue(DetailsUrl);
            var externalId = parseResult.GetRequiredValue(ExternalId);
            var startedAt = parseResult.GetRequiredValue(StartedAt);
            var status = parseResult.GetRequiredValue(Status);
            var conclusion = parseResult.GetRequiredValue(Conclusion);
            var completedAt = parseResult.GetRequiredValue(CompletedAt);
            var output = parseResult.GetRequiredValue(Output);
            var actions = parseResult.GetRequiredValue(Actions);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                checkRunId: checkRunId,
                name: name,
                detailsUrl: detailsUrl,
                externalId: externalId,
                startedAt: startedAt,
                status: status,
                conclusion: conclusion,
                completedAt: completedAt,
                output: output,
                actions: actions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Checks.ChecksUpdateAsync(
                owner: owner,
                repo: repo,
                checkRunId: checkRunId,
                name: name,
                detailsUrl: detailsUrl,
                externalId: externalId,
                startedAt: startedAt,
                status: status,
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
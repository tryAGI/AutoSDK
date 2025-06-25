//HintName: G.Commands.IssuesGetMilestoneCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesGetMilestoneCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int milestoneNumber,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Milestone response,
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

        private global::System.CommandLine.Argument<int> MilestoneNumber { get; } = new(
            name: "milestoneNumber")
        {
            Description = "",
        };

        public IssuesGetMilestoneCommand(G.IApi client) : base(
            name: "issues",
            description: @"Gets a milestone using the given milestone number.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(MilestoneNumber);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var milestoneNumber = parseResult.GetRequiredValue(MilestoneNumber);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                milestoneNumber: milestoneNumber,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesGetMilestoneAsync(
                owner: owner,
                repo: repo,
                milestoneNumber: milestoneNumber,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
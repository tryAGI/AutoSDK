//HintName: G.Commands.IssuesUpdateMilestoneCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesUpdateMilestoneCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int milestoneNumber,
            string? title,
            global::G.IssuesUpdateMilestoneRequestState? state,
            string? description,
            global::System.DateTime? dueOn,
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

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesUpdateMilestoneRequestState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> DueOn { get; } = new(
            name: "dueOn")
        {
            Description = "",
        };
        public IssuesUpdateMilestoneCommand(G.IApi client) : base(
            name: "issues",
            description: @"")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(MilestoneNumber);
            Options.Add(Title);
            Options.Add(State);
            Options.Add(Description);
            Options.Add(DueOn);

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
            var title = parseResult.GetRequiredValue(Title);
            var state = parseResult.GetRequiredValue(State);
            var description = parseResult.GetRequiredValue(Description);
            var dueOn = parseResult.GetRequiredValue(DueOn);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                milestoneNumber: milestoneNumber,
                title: title,
                state: state,
                description: description,
                dueOn: dueOn,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesUpdateMilestoneAsync(
                owner: owner,
                repo: repo,
                milestoneNumber: milestoneNumber,
                title: title,
                state: state,
                description: description,
                dueOn: dueOn,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
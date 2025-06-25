//HintName: G.Commands.IssuesCheckUserCanBeAssignedToIssueCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesCheckUserCanBeAssignedToIssueCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int issueNumber,
            string assignee,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private global::System.CommandLine.Argument<int> IssueNumber { get; } = new(
            name: "issueNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Assignee { get; } = new(
            name: "assignee")
        {
            Description = "",
        };

        public IssuesCheckUserCanBeAssignedToIssueCommand(G.IApi client) : base(
            name: "issues",
            description: @"Checks if a user has permission to be assigned to a specific issue.

If the `assignee` can be assigned to this issue, a `204` status code with no content is returned.

Otherwise a `404` status code is returned.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(IssueNumber);
            Arguments.Add(Assignee);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var issueNumber = parseResult.GetRequiredValue(IssueNumber);
            var assignee = parseResult.GetRequiredValue(Assignee);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                assignee: assignee,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Issues.IssuesCheckUserCanBeAssignedToIssueAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                assignee: assignee,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
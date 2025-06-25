//HintName: G.Commands.IssuesAddAssigneesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesAddAssigneesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int issueNumber,
            global::System.Collections.Generic.IList<string>? assignees,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Issue response,
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Assignees { get; } = new(
            name: "assignees")
        {
            Description = "",
        };
        public IssuesAddAssigneesCommand(G.IApi client) : base(
            name: "issues",
            description: @"Adds up to 10 assignees to an issue. Users already assigned to an issue are not replaced.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(IssueNumber);
            Options.Add(Assignees);

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
            var assignees = parseResult.GetRequiredValue(Assignees);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                assignees: assignees,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesAddAssigneesAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                assignees: assignees,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
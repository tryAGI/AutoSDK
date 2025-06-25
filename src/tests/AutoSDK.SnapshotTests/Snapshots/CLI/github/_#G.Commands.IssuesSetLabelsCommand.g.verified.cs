//HintName: G.Commands.IssuesSetLabelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesSetLabelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int issueNumber,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Label> response,
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

        public IssuesSetLabelsCommand(G.IApi client) : base(
            name: "issues",
            description: @"Removes any previous labels and sets the new labels for an issue.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(IssueNumber);

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

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesSetLabelsAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
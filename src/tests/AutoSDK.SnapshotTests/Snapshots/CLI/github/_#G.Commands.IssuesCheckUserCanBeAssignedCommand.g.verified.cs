//HintName: G.Commands.IssuesCheckUserCanBeAssignedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesCheckUserCanBeAssignedCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
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

        private global::System.CommandLine.Argument<string> Assignee { get; } = new(
            name: "assignee")
        {
            Description = "",
        };

        public IssuesCheckUserCanBeAssignedCommand(G.IApi client) : base(
            name: "issues",
            description: @"Checks if a user has permission to be assigned to an issue in this repository.

If the `assignee` can be assigned to issues in the repository, a `204` header with no content is returned.

Otherwise a `404` status code is returned.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
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
            var assignee = parseResult.GetRequiredValue(Assignee);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                assignee: assignee,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Issues.IssuesCheckUserCanBeAssignedAsync(
                owner: owner,
                repo: repo,
                assignee: assignee,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
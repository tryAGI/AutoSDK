//HintName: G.Commands.ReposMergeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposMergeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string @base,
            string head,
            string? commitMessage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Commit response,
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

        private global::System.CommandLine.Argument<string> Base { get; } = new(
            name: "@base")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Head { get; } = new(
            name: "head")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CommitMessage { get; } = new(
            name: "commitMessage")
        {
            Description = "",
        };
        public ReposMergeCommand(G.IApi client) : base(
            name: "repos",
            description: @"")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Base);
            Arguments.Add(Head);
            Options.Add(CommitMessage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var @base = parseResult.GetRequiredValue(Base);
            var head = parseResult.GetRequiredValue(Head);
            var commitMessage = parseResult.GetRequiredValue(CommitMessage);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                @base: @base,
                head: head,
                commitMessage: commitMessage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposMergeAsync(
                owner: owner,
                repo: repo,
                @base: @base,
                head: head,
                commitMessage: commitMessage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
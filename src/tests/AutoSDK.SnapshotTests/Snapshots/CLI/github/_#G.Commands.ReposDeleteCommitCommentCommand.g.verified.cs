//HintName: G.Commands.ReposDeleteCommitCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteCommitCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            long commentId,
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

        private global::System.CommandLine.Argument<long> CommentId { get; } = new(
            name: "commentId")
        {
            Description = "",
        };

        public ReposDeleteCommitCommentCommand(G.IApi client) : base(
            name: "repos",
            description: @"")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CommentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var commentId = parseResult.GetRequiredValue(CommentId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                commentId: commentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDeleteCommitCommentAsync(
                owner: owner,
                repo: repo,
                commentId: commentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
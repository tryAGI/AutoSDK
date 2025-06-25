//HintName: G.Commands.ReposDeleteFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string path,
            string message,
            string sha,
            string? branch,
            global::G.ReposDeleteFileRequestCommitter? committer,
            global::G.ReposDeleteFileRequestAuthor? author,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FileCommit response,
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

        private global::System.CommandLine.Argument<string> Path { get; } = new(
            name: "path")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Sha { get; } = new(
            name: "sha")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Branch { get; } = new(
            name: "branch")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposDeleteFileRequestCommitter?> Committer { get; } = new(
            name: "committer")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposDeleteFileRequestAuthor?> Author { get; } = new(
            name: "author")
        {
            Description = "",
        };
        public ReposDeleteFileCommand(G.IApi client) : base(
            name: "repos",
            description: @"Deletes a file in a repository.

You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.

The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user's information is used.

You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you'll receive a `422` status code.

> [!NOTE]
> If you use this endpoint and the ""[Create or update file contents](https://docs.github.com/rest/repos/contents/#create-or-update-file-contents)"" endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Path);
            Arguments.Add(Message);
            Arguments.Add(Sha);
            Options.Add(Branch);
            Options.Add(Committer);
            Options.Add(Author);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var path = parseResult.GetRequiredValue(Path);
            var message = parseResult.GetRequiredValue(Message);
            var sha = parseResult.GetRequiredValue(Sha);
            var branch = parseResult.GetRequiredValue(Branch);
            var committer = parseResult.GetRequiredValue(Committer);
            var author = parseResult.GetRequiredValue(Author);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                path: path,
                message: message,
                sha: sha,
                branch: branch,
                committer: committer,
                author: author,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposDeleteFileAsync(
                owner: owner,
                repo: repo,
                path: path,
                message: message,
                sha: sha,
                branch: branch,
                committer: committer,
                author: author,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
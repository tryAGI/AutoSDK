//HintName: G.Commands.ReposCreateOrUpdateFileContentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateOrUpdateFileContentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string path,
            string message,
            string content,
            string? sha,
            string? branch,
            global::G.ReposCreateOrUpdateFileContentsRequestCommitter? committer,
            global::G.ReposCreateOrUpdateFileContentsRequestAuthor? author,
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

        private global::System.CommandLine.Argument<string> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Sha { get; } = new(
            name: "sha")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Branch { get; } = new(
            name: "branch")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateOrUpdateFileContentsRequestCommitter?> Committer { get; } = new(
            name: "committer")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateOrUpdateFileContentsRequestAuthor?> Author { get; } = new(
            name: "author")
        {
            Description = "",
        };
        public ReposCreateOrUpdateFileContentsCommand(G.IApi client) : base(
            name: "repos",
            description: @"Creates a new file or replaces an existing file in a repository.

> [!NOTE]
> If you use this endpoint and the ""[Delete a file](https://docs.github.com/rest/repos/contents/#delete-a-file)"" endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint. The `workflow` scope is also required in order to modify files in the `.github/workflows` directory.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Path);
            Arguments.Add(Message);
            Arguments.Add(Content);
            Options.Add(Sha);
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
            var content = parseResult.GetRequiredValue(Content);
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
                content: content,
                sha: sha,
                branch: branch,
                committer: committer,
                author: author,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateOrUpdateFileContentsAsync(
                owner: owner,
                repo: repo,
                path: path,
                message: message,
                content: content,
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
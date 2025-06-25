//HintName: G.Commands.GitGetTreeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GitGetTreeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string treeSha,
            string? recursive,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GitTree response,
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

        private global::System.CommandLine.Argument<string> TreeSha { get; } = new(
            name: "treeSha")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Recursive { get; } = new(
            name: "recursive")
        {
            Description = "",
        };
        public GitGetTreeCommand(G.IApi client) : base(
            name: "git",
            description: @"Returns a single tree using the SHA1 value or ref name for that tree.

If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.

> [!NOTE]
> The limit for the `tree` array is 100,000 entries with a maximum size of 7 MB when using the `recursive` parameter.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(TreeSha);
            Options.Add(Recursive);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var treeSha = parseResult.GetRequiredValue(TreeSha);
            var recursive = parseResult.GetRequiredValue(Recursive);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                treeSha: treeSha,
                recursive: recursive,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Git.GitGetTreeAsync(
                owner: owner,
                repo: repo,
                treeSha: treeSha,
                recursive: recursive,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
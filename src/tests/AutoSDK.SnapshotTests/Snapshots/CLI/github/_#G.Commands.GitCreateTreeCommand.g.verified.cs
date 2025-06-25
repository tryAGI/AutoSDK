//HintName: G.Commands.GitCreateTreeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GitCreateTreeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::G.GitCreateTreeRequestTreeItem> tree,
            string? baseTree,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.GitCreateTreeRequestTreeItem>> Tree { get; } = new(
            name: "tree")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> BaseTree { get; } = new(
            name: "baseTree")
        {
            Description = "",
        };
        public GitCreateTreeCommand(G.IApi client) : base(
            name: "git",
            description: @"The tree creation API accepts nested entries. If you specify both a tree and a nested path modifying that tree, this endpoint will overwrite the contents of the tree with the new path contents, and create a new tree structure.

If you use this endpoint to add, delete, or modify the file contents in a tree, you will need to commit the tree and then update a branch to point to the commit. For more information see ""[Create a commit](https://docs.github.com/rest/git/commits#create-a-commit)"" and ""[Update a reference](https://docs.github.com/rest/git/refs#update-a-reference).""

Returns an error if you try to delete a file that does not exist.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Tree);
            Options.Add(BaseTree);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var tree = parseResult.GetRequiredValue(Tree);
            var baseTree = parseResult.GetRequiredValue(BaseTree);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                tree: tree,
                baseTree: baseTree,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Git.GitCreateTreeAsync(
                owner: owner,
                repo: repo,
                tree: tree,
                baseTree: baseTree,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.ReposRenameBranchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposRenameBranchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string branch,
            string newName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BranchWithProtection response,
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

        private global::System.CommandLine.Argument<string> Branch { get; } = new(
            name: "branch")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> NewName { get; } = new(
            name: "newName")
        {
            Description = "",
        };

        public ReposRenameBranchCommand(G.IApi client) : base(
            name: "repos",
            description: @"Renames a branch in a repository.

> [!NOTE]
> Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won't be able to push to the old branch name while the rename process is in progress. For more information, see ""[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)"".

The authenticated user must have push access to the branch. If the branch is the default branch, the authenticated user must also have admin or owner permissions.

In order to rename the default branch, fine-grained access tokens also need the `administration:write` repository permission.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Branch);
            Arguments.Add(NewName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var branch = parseResult.GetRequiredValue(Branch);
            var newName = parseResult.GetRequiredValue(NewName);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                branch: branch,
                newName: newName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposRenameBranchAsync(
                owner: owner,
                repo: repo,
                branch: branch,
                newName: newName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
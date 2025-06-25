//HintName: G.Commands.ReposRemoveCollaboratorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposRemoveCollaboratorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string username,
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

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        public ReposRemoveCollaboratorCommand(G.IApi client) : base(
            name: "repos",
            description: @"Removes a collaborator from a repository.

To use this endpoint, the authenticated user must either be an administrator of the repository or target themselves for removal.

This endpoint also:
- Cancels any outstanding invitations
- Unasigns the user from any issues
- Removes access to organization projects if the user is not an organization member and is not a collaborator on any other organization repositories.
- Unstars the repository
- Updates access permissions to packages

Removing a user as a collaborator has the following effects on forks:
 - If the user had access to a fork through their membership to this repository, the user will also be removed from the fork.
 - If the user had their own fork of the repository, the fork will be deleted.
 - If the user still has read access to the repository, open pull requests by this user from a fork will be denied.

> [!NOTE]
> A user can still have access to the repository through organization permissions like base repository permissions.

Although the API responds immediately, the additional permission updates might take some extra time to complete in the background.

For more information on fork permissions, see ""[About permissions and visibility of forks](https://docs.github.com/pull-requests/collaborating-with-pull-requests/working-with-forks/about-permissions-and-visibility-of-forks)"".")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Username);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var username = parseResult.GetRequiredValue(Username);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                username: username,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposRemoveCollaboratorAsync(
                owner: owner,
                repo: repo,
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
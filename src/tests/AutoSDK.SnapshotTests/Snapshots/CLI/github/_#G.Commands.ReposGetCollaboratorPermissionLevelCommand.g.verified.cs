//HintName: G.Commands.ReposGetCollaboratorPermissionLevelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetCollaboratorPermissionLevelCommand : global::System.CommandLine.Command
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
            global::G.RepositoryCollaboratorPermission response,
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

        public ReposGetCollaboratorPermissionLevelCommand(G.IApi client) : base(
            name: "repos",
            description: @"Checks the repository permission of a collaborator. The possible repository
permissions are `admin`, `write`, `read`, and `none`.

*Note*: The `permission` attribute provides the legacy base roles of `admin`, `write`, `read`, and `none`, where the
`maintain` role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role assigned to the
collaborator, see the `role_name` attribute, which will provide the full role name, including custom roles. The
`permissions` hash can also be used to determine which base level of access the collaborator has to the repository.")
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
            var response = await _client.Repos.ReposGetCollaboratorPermissionLevelAsync(
                owner: owner,
                repo: repo,
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
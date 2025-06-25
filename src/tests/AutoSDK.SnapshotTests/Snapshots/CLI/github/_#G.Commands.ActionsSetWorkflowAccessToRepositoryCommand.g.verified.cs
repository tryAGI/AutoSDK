//HintName: G.Commands.ActionsSetWorkflowAccessToRepositoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetWorkflowAccessToRepositoryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.ActionsWorkflowAccessToRepositoryAccessLevel accessLevel,
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

        private global::System.CommandLine.Argument<global::G.ActionsWorkflowAccessToRepositoryAccessLevel> AccessLevel { get; } = new(
            name: "accessLevel")
        {
            Description = "",
        };

        public ActionsSetWorkflowAccessToRepositoryCommand(G.IApi client) : base(
            name: "actions",
            description: @"Sets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository.
This endpoint only applies to private repositories.
For more information, see ""[Allowing access to components in a private repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-a-private-repository)"".

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(AccessLevel);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var accessLevel = parseResult.GetRequiredValue(AccessLevel);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                accessLevel: accessLevel,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsSetWorkflowAccessToRepositoryAsync(
                owner: owner,
                repo: repo,
                accessLevel: accessLevel,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
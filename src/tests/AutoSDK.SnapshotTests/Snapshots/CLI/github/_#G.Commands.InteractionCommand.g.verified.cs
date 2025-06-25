//HintName: G.Commands.InteractionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InteractionCommand : global::System.CommandLine.Command
    {
        public InteractionCommand(
            InteractionsGetRestrictionsForOrgCommand command0,
            InteractionsSetRestrictionsForOrgCommand command1,
            InteractionsRemoveRestrictionsForOrgCommand command2,
            InteractionsGetRestrictionsForRepoCommand command3,
            InteractionsSetRestrictionsForRepoCommand command4,
            InteractionsRemoveRestrictionsForRepoCommand command5,
            InteractionsGetRestrictionsForAuthenticatedUserCommand command6,
            InteractionsSetRestrictionsForAuthenticatedUserCommand command7,
            InteractionsRemoveRestrictionsForAuthenticatedUserCommand command8)
            : base(
                name: "interaction")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
        }
    }
}
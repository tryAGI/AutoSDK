//HintName: G.Commands.InviteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InviteCommand : global::System.CommandLine.Command
    {
        public InviteCommand(
            ListInvitesCommand command0,
            InviteUserCommand command1,
            RetrieveInviteCommand command2,
            DeleteInviteCommand command3)
            : base(
                name: "invite")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}
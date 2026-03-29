//HintName: G.Commands.UserOperationsV2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserOperationsV2GroupCommand : global::System.CommandLine.Command
    {
        public UserOperationsV2GroupCommand(
            UserOperationsV2CreateVectordbUsersCreateCommand command0,
            UserOperationsV2CreateVectordbUsersDescribeCommand command1,
            UserOperationsV2CreateVectordbUsersDropCommand command2,
            UserOperationsV2CreateVectordbUsersGrantRoleCommand command3,
            UserOperationsV2CreateVectordbUsersListCommand command4,
            UserOperationsV2CreateVectordbUsersRevokeRoleCommand command5,
            UserOperationsV2CreateVectordbUsersUpdatePasswordCommand command6)
            : base(
                name: "useroperationsv2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
        }
    }
}
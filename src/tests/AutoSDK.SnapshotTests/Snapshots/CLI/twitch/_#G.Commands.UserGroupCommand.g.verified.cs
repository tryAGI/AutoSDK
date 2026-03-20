//HintName: G.Commands.UserGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserGroupCommand : global::System.CommandLine.Command
    {
        public UserGroupCommand(
            UsersGetUsersCommand command0,
            UsersUpdateUserCommand command1,
            UsersGetUserBlockListCommand command2,
            UsersBlockUserCommand command3,
            UsersUnblockUserCommand command4,
            UsersGetUserExtensionsCommand command5,
            UsersGetUserActiveExtensionsCommand command6,
            UsersUpdateUserExtensionsCommand command7)
            : base(
                name: "user")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
        }
    }
}
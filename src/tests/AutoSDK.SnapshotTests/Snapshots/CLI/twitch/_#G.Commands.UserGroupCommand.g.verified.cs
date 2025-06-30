//HintName: G.Commands.UserGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserGroupCommand : global::System.CommandLine.Command
    {
        public UserGroupCommand(
            GetUsersCommand command0,
            UpdateUserCommand command1,
            GetUserBlockListCommand command2,
            BlockUserCommand command3,
            UnblockUserCommand command4,
            GetUserExtensionsCommand command5,
            GetUserActiveExtensionsCommand command6,
            UpdateUserExtensionsCommand command7)
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
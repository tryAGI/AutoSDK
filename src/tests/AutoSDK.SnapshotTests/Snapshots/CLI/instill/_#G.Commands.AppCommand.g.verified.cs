//HintName: G.Commands.AppCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppCommand : global::System.CommandLine.Command
    {
        public AppCommand(
            AppPublicServiceListAppsCommand command0,
            AppPublicServiceCreateAppCommand command1,
            AppPublicServiceUpdateAppCommand command2,
            AppPublicServiceDeleteAppCommand command3,
            AppPublicServiceListConversationsCommand command4,
            AppPublicServiceCreateConversationCommand command5,
            AppPublicServiceUpdateConversationCommand command6,
            AppPublicServiceDeleteConversationCommand command7,
            AppPublicServiceListMessagesCommand command8,
            AppPublicServiceCreateMessageCommand command9,
            AppPublicServiceUpdateMessageCommand command10,
            AppPublicServiceDeleteMessageCommand command11,
            AppPublicServiceGetPlaygroundConversationCommand command12,
            AppPublicServiceRestartPlaygroundConversationCommand command13,
            AppPublicServiceChatCommand command14)
            : base(
                name: "app")
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
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
        }
    }
}
//HintName: G.Commands.AppGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppGroupCommand : global::System.CommandLine.Command
    {
        public AppGroupCommand(
            AppAppPublicServiceListAppsCommand command0,
            AppAppPublicServiceCreateAppCommand command1,
            AppAppPublicServiceUpdateAppCommand command2,
            AppAppPublicServiceDeleteAppCommand command3,
            AppAppPublicServiceListConversationsCommand command4,
            AppAppPublicServiceCreateConversationCommand command5,
            AppAppPublicServiceUpdateConversationCommand command6,
            AppAppPublicServiceDeleteConversationCommand command7,
            AppAppPublicServiceListMessagesCommand command8,
            AppAppPublicServiceCreateMessageCommand command9,
            AppAppPublicServiceUpdateMessageCommand command10,
            AppAppPublicServiceDeleteMessageCommand command11,
            AppAppPublicServiceGetPlaygroundConversationCommand command12,
            AppAppPublicServiceRestartPlaygroundConversationCommand command13,
            AppAppPublicServiceChatCommand command14)
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
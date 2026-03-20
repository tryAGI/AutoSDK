//HintName: G.Commands.AppGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppGroupCommand : global::System.CommandLine.Command
    {
        public AppGroupCommand(
            AppAppPublicServiceChatCommand command0,
            AppAppPublicServiceCreateAppCommand command1,
            AppAppPublicServiceCreateConversationCommand command2,
            AppAppPublicServiceCreateMessageCommand command3,
            AppAppPublicServiceDeleteAppCommand command4,
            AppAppPublicServiceDeleteConversationCommand command5,
            AppAppPublicServiceDeleteMessageCommand command6,
            AppAppPublicServiceGetPlaygroundConversationCommand command7,
            AppAppPublicServiceListAppsCommand command8,
            AppAppPublicServiceListConversationsCommand command9,
            AppAppPublicServiceListMessagesCommand command10,
            AppAppPublicServiceRestartPlaygroundConversationCommand command11,
            AppAppPublicServiceUpdateAppCommand command12,
            AppAppPublicServiceUpdateConversationCommand command13,
            AppAppPublicServiceUpdateMessageCommand command14)
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
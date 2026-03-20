//HintName: G.Commands.ChatGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatGroupCommand : global::System.CommandLine.Command
    {
        public ChatGroupCommand(
            ChatGetChattersCommand command0,
            ChatGetChannelEmotesCommand command1,
            ChatGetGlobalEmotesCommand command2,
            ChatGetEmoteSetsCommand command3,
            ChatGetChannelChatBadgesCommand command4,
            ChatGetGlobalChatBadgesCommand command5,
            ChatGetChatSettingsCommand command6,
            ChatUpdateChatSettingsCommand command7,
            ChatGetUserEmotesCommand command8,
            ChatSendChatAnnouncementCommand command9,
            ChatSendAShoutoutCommand command10,
            ChatSendChatMessageCommand command11,
            ChatGetUserChatColorCommand command12,
            ChatUpdateUserChatColorCommand command13)
            : base(
                name: "chat")
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
        }
    }
}
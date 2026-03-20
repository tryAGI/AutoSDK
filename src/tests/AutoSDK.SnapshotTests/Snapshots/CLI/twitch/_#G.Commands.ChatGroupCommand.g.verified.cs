//HintName: G.Commands.ChatGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatGroupCommand : global::System.CommandLine.Command
    {
        public ChatGroupCommand(
            ChatGetChannelChatBadgesCommand command0,
            ChatGetChannelEmotesCommand command1,
            ChatGetChatSettingsCommand command2,
            ChatGetChattersCommand command3,
            ChatGetEmoteSetsCommand command4,
            ChatGetGlobalChatBadgesCommand command5,
            ChatGetGlobalEmotesCommand command6,
            ChatGetUserChatColorCommand command7,
            ChatGetUserEmotesCommand command8,
            ChatSendAShoutoutCommand command9,
            ChatSendChatAnnouncementCommand command10,
            ChatSendChatMessageCommand command11,
            ChatUpdateChatSettingsCommand command12,
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
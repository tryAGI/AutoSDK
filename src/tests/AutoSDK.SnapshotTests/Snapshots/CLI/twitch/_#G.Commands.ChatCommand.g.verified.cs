//HintName: G.Commands.ChatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatCommand : global::System.CommandLine.Command
    {
        public ChatCommand(
            GetChattersCommand command0,
            GetChannelEmotesCommand command1,
            GetGlobalEmotesCommand command2,
            GetEmoteSetsCommand command3,
            GetChannelChatBadgesCommand command4,
            GetGlobalChatBadgesCommand command5,
            GetChatSettingsCommand command6,
            UpdateChatSettingsCommand command7,
            GetUserEmotesCommand command8,
            SendChatAnnouncementCommand command9,
            SendAShoutoutCommand command10,
            SendChatMessageCommand command11,
            GetUserChatColorCommand command12,
            UpdateUserChatColorCommand command13)
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
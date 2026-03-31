//HintName: G.Commands.ChatGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatGroupCommand : global::System.CommandLine.Command
    {
        public ChatGroupCommand(
            ChatCreateChatCompletionCommand command0)
            : base(
                name: "chat")
        {
            Subcommands.Add(command0);
        }
    }
}
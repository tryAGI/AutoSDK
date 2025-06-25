//HintName: G.Commands.ChatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatCommand : global::System.CommandLine.Command
    {
        public ChatCommand(
            ListChatCompletionsCommand command0,
            CreateChatCompletionCommand command1,
            GetChatCompletionCommand command2,
            UpdateChatCompletionCommand command3,
            DeleteChatCompletionCommand command4,
            GetChatCompletionMessagesCommand command5)
            : base(
                name: "chat")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}
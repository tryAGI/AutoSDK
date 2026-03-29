//HintName: G.Commands.ChatCompletionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatCompletionGroupCommand : global::System.CommandLine.Command
    {
        public ChatCompletionGroupCommand(
            ChatCompletionsCreateChatCompletionsCommand command0,
            ChatCompletionsCreateChatCompletionsAsStreamCommand command1)
            : base(
                name: "chatcompletion")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
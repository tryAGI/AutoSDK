//HintName: G.Commands.ChatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatCommand : global::System.CommandLine.Command
    {
        public ChatCommand(
            GenerateChatCompletionCommand command0)
            : base(
                name: "chat")
        {
            Subcommands.Add(command0);
        }
    }
}
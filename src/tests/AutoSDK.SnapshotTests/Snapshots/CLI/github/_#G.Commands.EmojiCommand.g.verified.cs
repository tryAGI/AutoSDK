//HintName: G.Commands.EmojiCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmojiCommand : global::System.CommandLine.Command
    {
        public EmojiCommand(
            EmojisGetCommand command0)
            : base(
                name: "emoji")
        {
            Subcommands.Add(command0);
        }
    }
}
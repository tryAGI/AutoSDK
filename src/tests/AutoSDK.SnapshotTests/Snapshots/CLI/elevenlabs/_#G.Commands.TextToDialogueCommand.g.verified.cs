//HintName: G.Commands.TextToDialogueCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TextToDialogueCommand : global::System.CommandLine.Command
    {
        public TextToDialogueCommand(
            CreateTextToDialogueCommand command0,
            CreateTextToDialogueStreamCommand command1)
            : base(
                name: "texttodialogue")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
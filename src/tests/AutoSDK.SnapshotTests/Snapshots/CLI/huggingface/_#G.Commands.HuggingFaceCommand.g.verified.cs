//HintName: G.Commands.HuggingFaceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class HuggingFaceCommand : global::System.CommandLine.Command
    {
        public HuggingFaceCommand(
            GenerateTextCommand command0)
            : base(
                name: "huggingface")
        {
            Subcommands.Add(command0);
        }
    }
}
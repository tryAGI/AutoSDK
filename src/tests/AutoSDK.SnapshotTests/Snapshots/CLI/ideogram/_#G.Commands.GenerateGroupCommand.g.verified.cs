//HintName: G.Commands.GenerateGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateGroupCommand : global::System.CommandLine.Command
    {
        public GenerateGroupCommand(
            GeneratePostGenerateImageCommand command0,
            GeneratePostRemixImageCommand command1,
            GeneratePostUpscaleImageCommand command2)
            : base(
                name: "generate")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
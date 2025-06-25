//HintName: G.Commands.GenerateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateCommand : global::System.CommandLine.Command
    {
        public GenerateCommand(
            PostGenerateImageCommand command0,
            PostRemixImageCommand command1,
            PostUpscaleImageCommand command2)
            : base(
                name: "generate")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
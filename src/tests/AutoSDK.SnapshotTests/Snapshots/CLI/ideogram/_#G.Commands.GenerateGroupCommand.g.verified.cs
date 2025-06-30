//HintName: G.Commands.GenerateGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateGroupCommand : global::System.CommandLine.Command
    {
        public GenerateGroupCommand(
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
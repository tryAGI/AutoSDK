//HintName: G.Commands.VisionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VisionGroupCommand : global::System.CommandLine.Command
    {
        public VisionGroupCommand(
            PostDescribeCommand command0)
            : base(
                name: "vision")
        {
            Subcommands.Add(command0);
        }
    }
}
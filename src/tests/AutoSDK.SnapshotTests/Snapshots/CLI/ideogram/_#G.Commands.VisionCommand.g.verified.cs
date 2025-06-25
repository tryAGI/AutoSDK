//HintName: G.Commands.VisionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VisionCommand : global::System.CommandLine.Command
    {
        public VisionCommand(
            PostDescribeCommand command0)
            : base(
                name: "vision")
        {
            Subcommands.Add(command0);
        }
    }
}
//HintName: G.Commands.ClipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClipCommand : global::System.CommandLine.Command
    {
        public ClipCommand(
            CreateClipCommand command0,
            GetClipsCommand command1)
            : base(
                name: "clip")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
//HintName: G.Commands.ClipGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClipGroupCommand : global::System.CommandLine.Command
    {
        public ClipGroupCommand(
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
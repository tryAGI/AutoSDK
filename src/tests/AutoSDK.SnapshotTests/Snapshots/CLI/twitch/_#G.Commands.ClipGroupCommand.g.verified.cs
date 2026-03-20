//HintName: G.Commands.ClipGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClipGroupCommand : global::System.CommandLine.Command
    {
        public ClipGroupCommand(
            ClipsCreateClipCommand command0,
            ClipsGetClipsCommand command1)
            : base(
                name: "clip")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
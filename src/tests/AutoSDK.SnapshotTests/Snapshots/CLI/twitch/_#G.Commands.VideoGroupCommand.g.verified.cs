//HintName: G.Commands.VideoGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VideoGroupCommand : global::System.CommandLine.Command
    {
        public VideoGroupCommand(
            GetVideosCommand command0,
            DeleteVideosCommand command1)
            : base(
                name: "video")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
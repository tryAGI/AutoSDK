//HintName: G.Commands.VideoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VideoCommand : global::System.CommandLine.Command
    {
        public VideoCommand(
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
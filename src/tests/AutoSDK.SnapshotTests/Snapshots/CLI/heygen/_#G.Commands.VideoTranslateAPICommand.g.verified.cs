//HintName: G.Commands.VideoTranslateAPICommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VideoTranslateAPICommand : global::System.CommandLine.Command
    {
        public VideoTranslateAPICommand(
            V2VideoTranslateTargetLanguagesCommand command0,
            V2VideoTranslateCommand command1,
            V2VideoTranslateIdStatusCommand command2)
            : base(
                name: "videotranslateapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
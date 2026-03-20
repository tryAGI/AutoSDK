//HintName: G.Commands.VideoTranslateApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VideoTranslateApiGroupCommand : global::System.CommandLine.Command
    {
        public VideoTranslateApiGroupCommand(
            VideoTranslateApiV2VideoTranslateCommand command0,
            VideoTranslateApiV2VideoTranslateIdStatusCommand command1,
            VideoTranslateApiV2VideoTranslateTargetLanguagesCommand command2)
            : base(
                name: "videotranslateapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
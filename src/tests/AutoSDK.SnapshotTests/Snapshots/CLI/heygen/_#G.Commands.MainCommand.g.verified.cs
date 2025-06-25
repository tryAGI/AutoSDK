//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            ListCommand command0,
            CreateVideoAPICommand command1,
            TemplateAPICommand command2,
            VideoTranslateAPICommand command3,
            StreamingAPICommand command4,
            WebhookCommand command5,
            TalkingPhotoCommand command6,
            PersonalizedVideoCommand command7,
            UserCommand command8,
            AssetCommand command9)
            : base(
                description: "CLI tool")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
        }
    }
}
//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AssetGroupCommand command0,
            CreateVideoApiGroupCommand command1,
            ListGroupCommand command2,
            PersonalizedVideoGroupCommand command3,
            StreamingApiGroupCommand command4,
            TalkingPhotoGroupCommand command5,
            TemplateApiGroupCommand command6,
            UserGroupCommand command7,
            VideoTranslateApiGroupCommand command8,
            WebhookGroupCommand command9)
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
//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            ListGroupCommand command0,
            CreateVideoAPIGroupCommand command1,
            TemplateAPIGroupCommand command2,
            VideoTranslateAPIGroupCommand command3,
            StreamingAPIGroupCommand command4,
            WebhookGroupCommand command5,
            TalkingPhotoGroupCommand command6,
            PersonalizedVideoGroupCommand command7,
            UserGroupCommand command8,
            AssetGroupCommand command9)
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
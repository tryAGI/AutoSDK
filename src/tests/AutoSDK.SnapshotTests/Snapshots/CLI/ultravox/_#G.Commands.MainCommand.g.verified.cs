//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AccountCommand command0,
            AgentCommand command1,
            ApiKeyCommand command2,
            CallCommand command3,
            CorporaCommand command4,
            DeletedCallCommand command5,
            ModelCommand command6,
            SchemaCommand command7,
            ToolCommand command8,
            VoiceCommand command9,
            WebhookCommand command10)
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
            Subcommands.Add(command10);
        }
    }
}
//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AccountGroupCommand command0,
            AgentGroupCommand command1,
            ApiKeyGroupCommand command2,
            CallGroupCommand command3,
            CorporaGroupCommand command4,
            DeletedCallGroupCommand command5,
            ModelGroupCommand command6,
            SchemaGroupCommand command7,
            ToolGroupCommand command8,
            VoiceGroupCommand command9,
            WebhookGroupCommand command10)
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
//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AgentGroupCommand command0,
            ApiStatuGroupCommand command1,
            AuthGroupCommand command2,
            DatasetGroupCommand command3,
            FineTuneGroupCommand command4,
            InfillGroupCommand command5,
            PronunciationDictGroupCommand command6,
            SttGroupCommand command7,
            TtGroupCommand command8,
            VoiceChangerGroupCommand command9,
            VoiceGroupCommand command10)
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
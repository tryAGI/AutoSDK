//HintName: G.Commands.FineTuneGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FineTuneGroupCommand : global::System.CommandLine.Command
    {
        public FineTuneGroupCommand(
            FineTunesFineTunesCreateCommand command0,
            FineTunesFineTunesDeleteCommand command1,
            FineTunesFineTunesGetCommand command2,
            FineTunesFineTunesListCommand command3,
            FineTunesFineTunesListVoicesCommand command4)
            : base(
                name: "finetune")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}
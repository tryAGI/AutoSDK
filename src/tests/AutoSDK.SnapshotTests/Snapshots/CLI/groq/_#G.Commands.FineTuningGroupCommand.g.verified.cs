//HintName: G.Commands.FineTuningGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FineTuningGroupCommand : global::System.CommandLine.Command
    {
        public FineTuningGroupCommand(
            FineTuningCreateFineTuningCommand command0,
            FineTuningDeleteFineTuningCommand command1,
            FineTuningGetFineTuningCommand command2,
            FineTuningListFineTuningsCommand command3)
            : base(
                name: "finetuning")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}
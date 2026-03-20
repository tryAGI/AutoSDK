//HintName: G.Commands.Finetuning2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Finetuning2GroupCommand : global::System.CommandLine.Command
    {
        public Finetuning2GroupCommand(
            Finetuning2ListFinetunedModelsCommand command0,
            Finetuning2CreateFinetunedModelCommand command1,
            Finetuning2UpdateFinetunedModelCommand command2,
            Finetuning2GetFinetunedModelCommand command3,
            Finetuning2DeleteFinetunedModelCommand command4,
            Finetuning2ListEventsCommand command5,
            Finetuning2ListTrainingStepMetricsCommand command6)
            : base(
                name: "finetuning2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
        }
    }
}
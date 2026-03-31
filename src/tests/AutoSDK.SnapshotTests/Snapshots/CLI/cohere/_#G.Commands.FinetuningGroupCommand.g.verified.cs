//HintName: G.Commands.FinetuningGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FinetuningGroupCommand : global::System.CommandLine.Command
    {
        public FinetuningGroupCommand(
            FinetuningCreateFinetunedModelCommand command0,
            FinetuningDeleteFinetunedModelCommand command1,
            FinetuningGetFinetunedModelCommand command2,
            FinetuningListEventsCommand command3,
            FinetuningListFinetunedModelsCommand command4,
            FinetuningListTrainingStepMetricsCommand command5,
            FinetuningUpdateFinetunedModelCommand command6)
            : base(
                name: "finetuning")
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
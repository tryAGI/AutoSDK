//HintName: G.Commands.FinetuningGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FinetuningGroupCommand : global::System.CommandLine.Command
    {
        public FinetuningGroupCommand(
            ListFinetunedModelsCommand command0,
            CreateFinetunedModelCommand command1,
            ListEventsCommand command2,
            ListTrainingStepMetricsCommand command3,
            DeleteFinetunedModelCommand command4,
            GetFinetunedModelCommand command5,
            UpdateFinetunedModelCommand command6)
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
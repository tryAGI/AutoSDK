//HintName: G.Commands.ExperimentGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentGroupCommand : global::System.CommandLine.Command
    {
        public ExperimentGroupCommand(
            ExperimentsBatchUpdateExperimentsCommand command0,
            ExperimentsCreateExperimentCommand command1,
            ExperimentsCreateExperimentItemsCommand command2,
            ExperimentsDeleteExperimentItemsCommand command3,
            ExperimentsDeleteExperimentsByIdCommand command4,
            ExperimentsExperimentItemsBulkCommand command5,
            ExperimentsFindExperimentGroupsCommand command6,
            ExperimentsFindExperimentGroupsAggregationsCommand command7,
            ExperimentsFindExperimentsCommand command8,
            ExperimentsFindFeedbackScoreNamesCommand command9,
            ExperimentsFinishExperimentsCommand command10,
            ExperimentsGetExperimentByIdCommand command11,
            ExperimentsGetExperimentItemByIdCommand command12,
            ExperimentsStreamExperimentItemsCommand command13,
            ExperimentsStreamExperimentsCommand command14,
            ExperimentsUpdateExperimentCommand command15)
            : base(
                name: "experiment")
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
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
        }
    }
}
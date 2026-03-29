//HintName: G.Commands.OptimizationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OptimizationGroupCommand : global::System.CommandLine.Command
    {
        public OptimizationGroupCommand(
            OptimizationsCancelStudioOptimizationsCommand command0,
            OptimizationsCreateOptimizationCommand command1,
            OptimizationsDeleteOptimizationsByIdCommand command2,
            OptimizationsFindOptimizationsCommand command3,
            OptimizationsGetOptimizationByIdCommand command4,
            OptimizationsGetStudioOptimizationLogsCommand command5,
            OptimizationsUpdateOptimizationsByIdCommand command6,
            OptimizationsUpsertOptimizationCommand command7)
            : base(
                name: "optimization")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
        }
    }
}
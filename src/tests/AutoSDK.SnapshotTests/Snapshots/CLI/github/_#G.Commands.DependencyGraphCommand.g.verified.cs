//HintName: G.Commands.DependencyGraphCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependencyGraphCommand : global::System.CommandLine.Command
    {
        public DependencyGraphCommand(
            DependencyGraphDiffRangeCommand command0,
            DependencyGraphExportSbomCommand command1,
            DependencyGraphCreateRepositorySnapshotCommand command2)
            : base(
                name: "dependencygraph")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
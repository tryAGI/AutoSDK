//HintName: G.Commands.ClusterCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClusterCommand : global::System.CommandLine.Command
    {
        public ClusterCommand(
            ClusterGetStatisticsCommand command0)
            : base(
                name: "cluster")
        {
            Subcommands.Add(command0);
        }
    }
}
//HintName: G.Commands.SystemUsageGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SystemUsageGroupCommand : global::System.CommandLine.Command
    {
        public SystemUsageGroupCommand(
            SystemUsageGetDatasetBiInfoCommand command0,
            SystemUsageGetExperimentBiInfoCommand command1,
            SystemUsageGetSpansBiInfoCommand command2,
            SystemUsageGetSpansCountForWorkspacesCommand command3,
            SystemUsageGetTracesBiInfoCommand command4,
            SystemUsageGetTracesCountForWorkspacesCommand command5)
            : base(
                name: "systemusage")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}
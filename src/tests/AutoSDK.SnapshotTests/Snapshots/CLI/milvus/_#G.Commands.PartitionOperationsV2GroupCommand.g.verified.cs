//HintName: G.Commands.PartitionOperationsV2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PartitionOperationsV2GroupCommand : global::System.CommandLine.Command
    {
        public PartitionOperationsV2GroupCommand(
            PartitionOperationsV2CreateVectordbPartitionsCreateCommand command0,
            PartitionOperationsV2CreateVectordbPartitionsDropCommand command1,
            PartitionOperationsV2CreateVectordbPartitionsGetStatsCommand command2,
            PartitionOperationsV2CreateVectordbPartitionsHasCommand command3,
            PartitionOperationsV2CreateVectordbPartitionsListCommand command4,
            PartitionOperationsV2CreateVectordbPartitionsLoadCommand command5,
            PartitionOperationsV2CreateVectordbPartitionsReleaseCommand command6)
            : base(
                name: "partitionoperationsv2")
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
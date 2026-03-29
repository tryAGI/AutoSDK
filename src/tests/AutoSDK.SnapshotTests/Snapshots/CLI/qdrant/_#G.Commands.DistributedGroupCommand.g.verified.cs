//HintName: G.Commands.DistributedGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DistributedGroupCommand : global::System.CommandLine.Command
    {
        public DistributedGroupCommand(
            DistributedClusterStatusCommand command0,
            DistributedClusterTelemetryCommand command1,
            DistributedCollectionClusterInfoCommand command2,
            DistributedCreateShardKeyCommand command3,
            DistributedDeleteShardKeyCommand command4,
            DistributedListShardKeysCommand command5,
            DistributedRecoverCurrentPeerCommand command6,
            DistributedRemovePeerCommand command7,
            DistributedUpdateCollectionClusterCommand command8)
            : base(
                name: "distributed")
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
        }
    }
}
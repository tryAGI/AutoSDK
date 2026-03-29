//HintName: G.Commands.SnapshotGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SnapshotGroupCommand : global::System.CommandLine.Command
    {
        public SnapshotGroupCommand(
            SnapshotsCreateFullSnapshotCommand command0,
            SnapshotsCreateShardSnapshotCommand command1,
            SnapshotsCreateSnapshotCommand command2,
            SnapshotsDeleteFullSnapshotCommand command3,
            SnapshotsDeleteShardSnapshotCommand command4,
            SnapshotsDeleteSnapshotCommand command5,
            SnapshotsGetFullSnapshotCommand command6,
            SnapshotsGetShardSnapshotCommand command7,
            SnapshotsGetSnapshotCommand command8,
            SnapshotsListFullSnapshotsCommand command9,
            SnapshotsListShardSnapshotsCommand command10,
            SnapshotsListSnapshotsCommand command11,
            SnapshotsRecoverFromSnapshotCommand command12,
            SnapshotsRecoverFromUploadedSnapshotCommand command13,
            SnapshotsRecoverShardFromSnapshotCommand command14,
            SnapshotsRecoverShardFromUploadedSnapshotCommand command15,
            SnapshotsStreamShardSnapshotCommand command16)
            : base(
                name: "snapshot")
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
            Subcommands.Add(command16);
        }
    }
}
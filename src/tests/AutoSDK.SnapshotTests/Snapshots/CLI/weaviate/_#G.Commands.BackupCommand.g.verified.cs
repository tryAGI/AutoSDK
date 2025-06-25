//HintName: G.Commands.BackupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BackupCommand : global::System.CommandLine.Command
    {
        public BackupCommand(
            BackupsListCommand command0,
            BackupsCreateCommand command1,
            BackupsCreateStatusCommand command2,
            BackupsCancelCommand command3,
            BackupsRestoreStatusCommand command4,
            BackupsRestoreCommand command5)
            : base(
                name: "backup")
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
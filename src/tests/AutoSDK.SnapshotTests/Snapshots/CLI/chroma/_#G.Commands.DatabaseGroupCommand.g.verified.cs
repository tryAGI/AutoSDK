//HintName: G.Commands.DatabaseGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatabaseGroupCommand : global::System.CommandLine.Command
    {
        public DatabaseGroupCommand(
            DatabaseCreateDatabaseCommand command0,
            DatabaseDeleteDatabaseCommand command1,
            DatabaseGetDatabaseCommand command2,
            DatabaseListDatabasesCommand command3)
            : base(
                name: "database")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}
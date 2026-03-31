//HintName: G.Commands.DatasetGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetGroupCommand : global::System.CommandLine.Command
    {
        public DatasetGroupCommand(
            DatasetsCreateCommand command0,
            DatasetsDeleteCommand command1,
            DatasetsGetCommand command2,
            DatasetsGetUsageCommand command3,
            DatasetsListCommand command4)
            : base(
                name: "dataset")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}
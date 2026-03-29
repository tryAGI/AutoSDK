//HintName: G.Commands.RecordGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RecordGroupCommand : global::System.CommandLine.Command
    {
        public RecordGroupCommand(
            RecordCollectionAddCommand command0,
            RecordCollectionCountCommand command1,
            RecordCollectionDeleteCommand command2,
            RecordCollectionGetCommand command3,
            RecordCollectionQueryCommand command4,
            RecordCollectionSearchCommand command5,
            RecordCollectionUpdateCommand command6,
            RecordCollectionUpsertCommand command7,
            RecordIndexingStatusCommand command8)
            : base(
                name: "record")
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
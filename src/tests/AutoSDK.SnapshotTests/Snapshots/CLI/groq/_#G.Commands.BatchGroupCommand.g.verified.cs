//HintName: G.Commands.BatchGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchGroupCommand : global::System.CommandLine.Command
    {
        public BatchGroupCommand(
            BatchCancelBatchCommand command0,
            BatchCreateBatchCommand command1,
            BatchListBatchesCommand command2,
            BatchRetrieveBatchCommand command3)
            : base(
                name: "batch")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}
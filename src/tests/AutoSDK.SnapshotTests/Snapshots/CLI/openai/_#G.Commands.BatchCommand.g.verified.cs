//HintName: G.Commands.BatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchCommand : global::System.CommandLine.Command
    {
        public BatchCommand(
            CreateBatchCommand command0,
            ListBatchesCommand command1,
            RetrieveBatchCommand command2,
            CancelBatchCommand command3)
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
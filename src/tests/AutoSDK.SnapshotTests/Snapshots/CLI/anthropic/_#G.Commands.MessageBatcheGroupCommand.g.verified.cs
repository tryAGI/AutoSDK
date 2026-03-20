//HintName: G.Commands.MessageBatcheGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessageBatcheGroupCommand : global::System.CommandLine.Command
    {
        public MessageBatcheGroupCommand(
            MessageBatchesBetaMessageBatchesCancelCommand command0,
            MessageBatchesBetaMessageBatchesDeleteCommand command1,
            MessageBatchesBetaMessageBatchesListCommand command2,
            MessageBatchesBetaMessageBatchesPostCommand command3,
            MessageBatchesBetaMessageBatchesResultsCommand command4,
            MessageBatchesBetaMessageBatchesRetrieveCommand command5,
            MessageBatchesMessageBatchesCancelCommand command6,
            MessageBatchesMessageBatchesDeleteCommand command7,
            MessageBatchesMessageBatchesListCommand command8,
            MessageBatchesMessageBatchesPostCommand command9,
            MessageBatchesMessageBatchesResultsCommand command10,
            MessageBatchesMessageBatchesRetrieveCommand command11)
            : base(
                name: "messagebatche")
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
        }
    }
}
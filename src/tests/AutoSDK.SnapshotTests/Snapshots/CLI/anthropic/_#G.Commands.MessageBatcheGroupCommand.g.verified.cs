//HintName: G.Commands.MessageBatcheGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessageBatcheGroupCommand : global::System.CommandLine.Command
    {
        public MessageBatcheGroupCommand(
            MessageBatchesMessageBatchesPostCommand command0,
            MessageBatchesMessageBatchesListCommand command1,
            MessageBatchesMessageBatchesRetrieveCommand command2,
            MessageBatchesMessageBatchesDeleteCommand command3,
            MessageBatchesMessageBatchesCancelCommand command4,
            MessageBatchesMessageBatchesResultsCommand command5,
            MessageBatchesBetaMessageBatchesPostCommand command6,
            MessageBatchesBetaMessageBatchesListCommand command7,
            MessageBatchesBetaMessageBatchesRetrieveCommand command8,
            MessageBatchesBetaMessageBatchesDeleteCommand command9,
            MessageBatchesBetaMessageBatchesCancelCommand command10,
            MessageBatchesBetaMessageBatchesResultsCommand command11)
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
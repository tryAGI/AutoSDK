//HintName: G.Commands.MessageBatcheCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessageBatcheCommand : global::System.CommandLine.Command
    {
        public MessageBatcheCommand(
            MessageBatchesPostCommand command0,
            MessageBatchesListCommand command1,
            MessageBatchesRetrieveCommand command2,
            MessageBatchesDeleteCommand command3,
            MessageBatchesCancelCommand command4,
            MessageBatchesResultsCommand command5,
            BetaMessageBatchesPostCommand command6,
            BetaMessageBatchesListCommand command7,
            BetaMessageBatchesRetrieveCommand command8,
            BetaMessageBatchesDeleteCommand command9,
            BetaMessageBatchesCancelCommand command10,
            BetaMessageBatchesResultsCommand command11)
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
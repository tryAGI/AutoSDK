//HintName: G.Commands.LeMUR2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LeMUR2GroupCommand : global::System.CommandLine.Command
    {
        public LeMUR2GroupCommand(
            LeMUR2ActionItemsCommand command0,
            LeMUR2GetResponseCommand command1,
            LeMUR2PurgeRequestDataCommand command2,
            LeMUR2QuestionAnswerCommand command3,
            LeMUR2SummaryCommand command4,
            LeMUR2TaskCommand command5)
            : base(
                name: "lemur2")
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
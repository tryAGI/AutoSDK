//HintName: G.Commands.LeMURGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LeMURGroupCommand : global::System.CommandLine.Command
    {
        public LeMURGroupCommand(
            LemurTaskCommand command0,
            LemurSummaryCommand command1,
            LemurQuestionAnswerCommand command2,
            LemurActionItemsCommand command3,
            GetLemurResponseCommand command4,
            PurgeLemurRequestDataCommand command5)
            : base(
                name: "lemur")
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
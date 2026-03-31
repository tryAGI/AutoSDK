//HintName: G.Commands.LemurGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LemurGroupCommand : global::System.CommandLine.Command
    {
        public LemurGroupCommand(
            LemurActionItemsCommand command0,
            LemurGetResponseCommand command1,
            LemurPurgeRequestDataCommand command2,
            LemurQuestionAnswerCommand command3,
            LemurSummaryCommand command4,
            LemurTaskCommand command5)
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
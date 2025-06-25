//HintName: G.Commands.EvalCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EvalCommand : global::System.CommandLine.Command
    {
        public EvalCommand(
            ListEvalsCommand command0,
            CreateEvalCommand command1,
            GetEvalCommand command2,
            UpdateEvalCommand command3,
            DeleteEvalCommand command4,
            GetEvalRunsCommand command5,
            CreateEvalRunCommand command6,
            GetEvalRunCommand command7,
            CancelEvalRunCommand command8,
            DeleteEvalRunCommand command9,
            GetEvalRunOutputItemsCommand command10,
            GetEvalRunOutputItemCommand command11)
            : base(
                name: "eval")
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
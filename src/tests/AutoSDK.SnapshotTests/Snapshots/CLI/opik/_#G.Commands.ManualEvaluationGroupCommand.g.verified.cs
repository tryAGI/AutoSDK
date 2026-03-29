//HintName: G.Commands.ManualEvaluationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManualEvaluationGroupCommand : global::System.CommandLine.Command
    {
        public ManualEvaluationGroupCommand(
            ManualEvaluationEvaluateSpansCommand command0,
            ManualEvaluationEvaluateThreadsCommand command1,
            ManualEvaluationEvaluateTracesCommand command2)
            : base(
                name: "manualevaluation")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
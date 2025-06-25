//HintName: G.Commands.PredictionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PredictionCommand : global::System.CommandLine.Command
    {
        public PredictionCommand(
            GetPredictionsCommand command0,
            CreatePredictionCommand command1,
            EndPredictionCommand command2)
            : base(
                name: "prediction")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
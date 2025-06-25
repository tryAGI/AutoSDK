//HintName: G.Commands.HypeTrainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class HypeTrainCommand : global::System.CommandLine.Command
    {
        public HypeTrainCommand(
            GetHypeTrainEventsCommand command0)
            : base(
                name: "hypetrain")
        {
            Subcommands.Add(command0);
        }
    }
}
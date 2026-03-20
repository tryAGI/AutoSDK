//HintName: G.Commands.HypeTrainGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class HypeTrainGroupCommand : global::System.CommandLine.Command
    {
        public HypeTrainGroupCommand(
            HypeTrainGetHypeTrainEventsCommand command0)
            : base(
                name: "hypetrain")
        {
            Subcommands.Add(command0);
        }
    }
}
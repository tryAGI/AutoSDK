//HintName: G.Commands.HypeTrainGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class HypeTrainGroupCommand : global::System.CommandLine.Command
    {
        public HypeTrainGroupCommand(
            GetHypeTrainEventsCommand command0)
            : base(
                name: "hypetrain")
        {
            Subcommands.Add(command0);
        }
    }
}
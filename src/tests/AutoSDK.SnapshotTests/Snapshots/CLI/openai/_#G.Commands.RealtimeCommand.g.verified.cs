//HintName: G.Commands.RealtimeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RealtimeCommand : global::System.CommandLine.Command
    {
        public RealtimeCommand(
            CreateRealtimeSessionCommand command0,
            CreateRealtimeTranscriptionSessionCommand command1)
            : base(
                name: "realtime")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
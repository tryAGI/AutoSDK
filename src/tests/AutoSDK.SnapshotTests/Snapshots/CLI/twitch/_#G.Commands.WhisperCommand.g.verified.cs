//HintName: G.Commands.WhisperCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WhisperCommand : global::System.CommandLine.Command
    {
        public WhisperCommand(
            SendWhisperCommand command0)
            : base(
                name: "whisper")
        {
            Subcommands.Add(command0);
        }
    }
}
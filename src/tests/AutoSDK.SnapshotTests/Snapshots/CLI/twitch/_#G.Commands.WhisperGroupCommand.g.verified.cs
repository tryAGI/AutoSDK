//HintName: G.Commands.WhisperGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WhisperGroupCommand : global::System.CommandLine.Command
    {
        public WhisperGroupCommand(
            SendWhisperCommand command0)
            : base(
                name: "whisper")
        {
            Subcommands.Add(command0);
        }
    }
}
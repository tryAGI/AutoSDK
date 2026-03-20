//HintName: G.Commands.WhisperGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WhisperGroupCommand : global::System.CommandLine.Command
    {
        public WhisperGroupCommand(
            WhispersSendWhisperCommand command0)
            : base(
                name: "whisper")
        {
            Subcommands.Add(command0);
        }
    }
}
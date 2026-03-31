//HintName: G.Commands.SttGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SttGroupCommand : global::System.CommandLine.Command
    {
        public SttGroupCommand(
            SttSttTranscribeCommand command0)
            : base(
                name: "stt")
        {
            Subcommands.Add(command0);
        }
    }
}
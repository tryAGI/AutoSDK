//HintName: G.Commands.ResponseGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResponseGroupCommand : global::System.CommandLine.Command
    {
        public ResponseGroupCommand(
            ResponsesCreateResponseCommand command0)
            : base(
                name: "response")
        {
            Subcommands.Add(command0);
        }
    }
}
//HintName: G.Commands.ResponseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResponseCommand : global::System.CommandLine.Command
    {
        public ResponseCommand(
            CreateResponseCommand command0,
            GetResponseCommand command1,
            DeleteResponseCommand command2,
            CancelResponseCommand command3,
            ListInputItemsCommand command4)
            : base(
                name: "response")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}
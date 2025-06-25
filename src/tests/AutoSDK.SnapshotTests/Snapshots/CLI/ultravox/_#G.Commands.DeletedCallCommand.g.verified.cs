//HintName: G.Commands.DeletedCallCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeletedCallCommand : global::System.CommandLine.Command
    {
        public DeletedCallCommand(
            DeletedCallsListCommand command0,
            DeletedCallsRetrieveCommand command1)
            : base(
                name: "deletedcall")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
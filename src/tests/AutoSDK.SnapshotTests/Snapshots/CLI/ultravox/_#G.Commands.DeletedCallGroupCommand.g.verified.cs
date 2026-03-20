//HintName: G.Commands.DeletedCallGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeletedCallGroupCommand : global::System.CommandLine.Command
    {
        public DeletedCallGroupCommand(
            DeletedCallsDeletedCallsListCommand command0,
            DeletedCallsDeletedCallsRetrieveCommand command1)
            : base(
                name: "deletedcall")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
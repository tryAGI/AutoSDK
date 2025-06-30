//HintName: G.Commands.DeletedCallGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeletedCallGroupCommand : global::System.CommandLine.Command
    {
        public DeletedCallGroupCommand(
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
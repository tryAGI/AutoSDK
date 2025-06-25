//HintName: G.Commands.BatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchCommand : global::System.CommandLine.Command
    {
        public BatchCommand(
            BatchObjectsCreateCommand command0,
            BatchObjectsDeleteCommand command1,
            BatchReferencesCreateCommand command2)
            : base(
                name: "batch")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
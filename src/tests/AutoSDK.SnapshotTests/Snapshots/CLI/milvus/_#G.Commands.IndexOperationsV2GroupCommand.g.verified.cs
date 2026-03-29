//HintName: G.Commands.IndexOperationsV2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IndexOperationsV2GroupCommand : global::System.CommandLine.Command
    {
        public IndexOperationsV2GroupCommand(
            IndexOperationsV2CreateVectordbIndexesCreateCommand command0,
            IndexOperationsV2CreateVectordbIndexesDescribeCommand command1,
            IndexOperationsV2CreateVectordbIndexesDropCommand command2,
            IndexOperationsV2CreateVectordbIndexesListCommand command3)
            : base(
                name: "indexoperationsv2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}
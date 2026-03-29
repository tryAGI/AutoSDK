//HintName: G.Commands.PointGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PointGroupCommand : global::System.CommandLine.Command
    {
        public PointGroupCommand(
            PointsBatchUpdateCommand command0,
            PointsClearPayloadCommand command1,
            PointsCountPointsCommand command2,
            PointsDeletePayloadCommand command3,
            PointsDeletePointsCommand command4,
            PointsDeleteVectorsCommand command5,
            PointsFacetCommand command6,
            PointsGetPointCommand command7,
            PointsGetPointsCommand command8,
            PointsOverwritePayloadCommand command9,
            PointsScrollPointsCommand command10,
            PointsSetPayloadCommand command11,
            PointsUpdateVectorsCommand command12,
            PointsUpsertPointsCommand command13)
            : base(
                name: "point")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
        }
    }
}
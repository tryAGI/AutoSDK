//HintName: G.Commands.VectorOperationsV2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VectorOperationsV2GroupCommand : global::System.CommandLine.Command
    {
        public VectorOperationsV2GroupCommand(
            VectorOperationsV2CreateVectordbEntitiesDeleteCommand command0,
            VectorOperationsV2CreateVectordbEntitiesGetCommand command1,
            VectorOperationsV2CreateVectordbEntitiesInsertCommand command2,
            VectorOperationsV2CreateVectordbEntitiesQueryCommand command3,
            VectorOperationsV2CreateVectordbEntitiesSearchCommand command4,
            VectorOperationsV2CreateVectordbEntitiesUpsertCommand command5)
            : base(
                name: "vectoroperationsv2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}
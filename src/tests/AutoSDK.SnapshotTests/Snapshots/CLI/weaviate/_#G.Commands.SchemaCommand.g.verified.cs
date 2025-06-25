//HintName: G.Commands.SchemaCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaCommand : global::System.CommandLine.Command
    {
        public SchemaCommand(
            SchemaDumpCommand command0,
            SchemaObjectsCreateCommand command1,
            SchemaObjectsGetCommand command2,
            SchemaObjectsUpdateCommand command3,
            SchemaObjectsDeleteCommand command4,
            SchemaObjectsPropertiesAddCommand command5,
            SchemaObjectsShardsGetCommand command6,
            SchemaObjectsShardsUpdateCommand command7,
            TenantsGetCommand command8,
            TenantsUpdateCommand command9,
            TenantsCreateCommand command10,
            TenantsDeleteCommand command11,
            TenantExistsCommand command12)
            : base(
                name: "schema")
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
        }
    }
}
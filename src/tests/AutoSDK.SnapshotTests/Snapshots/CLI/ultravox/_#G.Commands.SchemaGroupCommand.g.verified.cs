//HintName: G.Commands.SchemaGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaGroupCommand : global::System.CommandLine.Command
    {
        public SchemaGroupCommand(
            SchemaRetrieveCommand command0)
            : base(
                name: "schema")
        {
            Subcommands.Add(command0);
        }
    }
}
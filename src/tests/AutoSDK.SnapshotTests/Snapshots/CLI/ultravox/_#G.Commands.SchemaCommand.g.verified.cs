//HintName: G.Commands.SchemaCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaCommand : global::System.CommandLine.Command
    {
        public SchemaCommand(
            SchemaRetrieveCommand command0)
            : base(
                name: "schema")
        {
            Subcommands.Add(command0);
        }
    }
}
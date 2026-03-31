//HintName: G.Commands.ExtractionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtractionGroupCommand : global::System.CommandLine.Command
    {
        public ExtractionGroupCommand(
            ExtractionsCreateExtractionJobCommand command0,
            ExtractionsCreateSchemaCommand command1,
            ExtractionsEnhanceSchemaCommand command2,
            ExtractionsExtractContentCommand command3,
            ExtractionsRetrieveExtractionJobCommand command4,
            ExtractionsValidateSchemaCommand command5)
            : base(
                name: "extraction")
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
//HintName: G.Commands.ExtractionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtractionGroupCommand : global::System.CommandLine.Command
    {
        public ExtractionGroupCommand(
            ExtractionExtractDataCommand command0,
            ExtractionGetExtractStatusCommand command1)
            : base(
                name: "extraction")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
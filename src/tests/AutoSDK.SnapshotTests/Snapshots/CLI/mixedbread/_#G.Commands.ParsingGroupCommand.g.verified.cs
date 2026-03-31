//HintName: G.Commands.ParsingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ParsingGroupCommand : global::System.CommandLine.Command
    {
        public ParsingGroupCommand(
            ParsingCancelParsingJobCommand command0,
            ParsingCreateParsingJobCommand command1,
            ParsingDeleteParsingJobCommand command2,
            ParsingListParsingJobsCommand command3,
            ParsingRetrieveParsingJobCommand command4)
            : base(
                name: "parsing")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}
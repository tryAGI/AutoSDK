//HintName: G.Commands.SearchGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchGroupCommand : global::System.CommandLine.Command
    {
        public SearchGroupCommand(
            SearchSearchAndScrapeCommand command0)
            : base(
                name: "search")
        {
            Subcommands.Add(command0);
        }
    }
}
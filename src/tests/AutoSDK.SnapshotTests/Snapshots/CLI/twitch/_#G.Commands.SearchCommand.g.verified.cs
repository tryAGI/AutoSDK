//HintName: G.Commands.SearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchCommand : global::System.CommandLine.Command
    {
        public SearchCommand(
            SearchCategoriesCommand command0,
            SearchChannelsCommand command1)
            : base(
                name: "search")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
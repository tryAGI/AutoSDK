//HintName: G.Commands.SearchGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchGroupCommand : global::System.CommandLine.Command
    {
        public SearchGroupCommand(
            SearchSearchCategoriesCommand command0,
            SearchSearchChannelsCommand command1)
            : base(
                name: "search")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
//HintName: G.Commands.SearchGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchGroupCommand : global::System.CommandLine.Command
    {
        public SearchGroupCommand(
            SearchDiscoverBatchPointsCommand command0,
            SearchDiscoverPointsCommand command1,
            SearchQueryBatchPointsCommand command2,
            SearchQueryPointsCommand command3,
            SearchQueryPointsGroupsCommand command4,
            SearchRecommendBatchPointsCommand command5,
            SearchRecommendPointGroupsCommand command6,
            SearchRecommendPointsCommand command7,
            SearchSearchBatchPointsCommand command8,
            SearchSearchMatrixOffsetsCommand command9,
            SearchSearchMatrixPairsCommand command10,
            SearchSearchPointGroupsCommand command11,
            SearchSearchPointsCommand command12)
            : base(
                name: "search")
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
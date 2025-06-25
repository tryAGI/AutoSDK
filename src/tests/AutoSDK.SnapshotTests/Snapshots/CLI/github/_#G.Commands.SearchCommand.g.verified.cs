//HintName: G.Commands.SearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchCommand : global::System.CommandLine.Command
    {
        public SearchCommand(
            SearchCodeCommand command0,
            SearchCommitsCommand command1,
            SearchIssuesAndPullRequestsCommand command2,
            SearchLabelsCommand command3,
            SearchReposCommand command4,
            SearchTopicsCommand command5,
            SearchUsersCommand command6)
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
        }
    }
}
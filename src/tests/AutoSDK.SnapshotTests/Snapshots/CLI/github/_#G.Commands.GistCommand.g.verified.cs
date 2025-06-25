//HintName: G.Commands.GistCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GistCommand : global::System.CommandLine.Command
    {
        public GistCommand(
            GistsListCommand command0,
            GistsCreateCommand command1,
            GistsListPublicCommand command2,
            GistsListStarredCommand command3,
            GistsGetCommand command4,
            GistsUpdateCommand command5,
            GistsDeleteCommand command6,
            GistsListCommentsCommand command7,
            GistsCreateCommentCommand command8,
            GistsGetCommentCommand command9,
            GistsUpdateCommentCommand command10,
            GistsDeleteCommentCommand command11,
            GistsListCommitsCommand command12,
            GistsListForksCommand command13,
            GistsForkCommand command14,
            GistsCheckIsStarredCommand command15,
            GistsStarCommand command16,
            GistsUnstarCommand command17,
            GistsGetRevisionCommand command18,
            GistsListForUserCommand command19)
            : base(
                name: "gist")
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
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
        }
    }
}
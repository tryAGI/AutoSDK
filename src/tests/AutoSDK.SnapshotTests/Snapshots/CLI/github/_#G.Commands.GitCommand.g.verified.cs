//HintName: G.Commands.GitCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GitCommand : global::System.CommandLine.Command
    {
        public GitCommand(
            GitCreateBlobCommand command0,
            GitGetBlobCommand command1,
            GitCreateCommitCommand command2,
            GitGetCommitCommand command3,
            GitListMatchingRefsCommand command4,
            GitGetRefCommand command5,
            GitCreateRefCommand command6,
            GitUpdateRefCommand command7,
            GitDeleteRefCommand command8,
            GitCreateTagCommand command9,
            GitGetTagCommand command10,
            GitCreateTreeCommand command11,
            GitGetTreeCommand command12)
            : base(
                name: "git")
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
//HintName: G.Commands.GitignoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GitignoreCommand : global::System.CommandLine.Command
    {
        public GitignoreCommand(
            GitignoreGetAllTemplatesCommand command0,
            GitignoreGetTemplateCommand command1)
            : base(
                name: "gitignore")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
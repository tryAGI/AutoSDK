//HintName: G.Commands.PromptGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptGroupCommand : global::System.CommandLine.Command
    {
        public PromptGroupCommand(
            PromptsCreatePromptCommand command0,
            PromptsCreatePromptVersionCommand command1,
            PromptsDeletePromptCommand command2,
            PromptsDeletePromptsBatchCommand command3,
            PromptsGetPromptByCommitCommand command4,
            PromptsGetPromptByIdCommand command5,
            PromptsGetPromptVersionByIdCommand command6,
            PromptsGetPromptVersionsCommand command7,
            PromptsGetPromptsCommand command8,
            PromptsGetPromptsByCommitsCommand command9,
            PromptsRestorePromptVersionCommand command10,
            PromptsRetrievePromptVersionCommand command11,
            PromptsUpdatePromptCommand command12,
            PromptsUpdatePromptVersionsCommand command13)
            : base(
                name: "prompt")
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
        }
    }
}
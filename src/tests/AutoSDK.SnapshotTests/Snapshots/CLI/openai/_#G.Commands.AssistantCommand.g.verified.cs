//HintName: G.Commands.AssistantCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AssistantCommand : global::System.CommandLine.Command
    {
        public AssistantCommand(
            ListAssistantsCommand command0,
            CreateAssistantCommand command1,
            GetAssistantCommand command2,
            ModifyAssistantCommand command3,
            DeleteAssistantCommand command4,
            CreateThreadCommand command5,
            CreateThreadAndRunCommand command6,
            GetThreadCommand command7,
            ModifyThreadCommand command8,
            DeleteThreadCommand command9,
            ListMessagesCommand command10,
            CreateMessageCommand command11,
            GetMessageCommand command12,
            ModifyMessageCommand command13,
            DeleteMessageCommand command14,
            ListRunsCommand command15,
            CreateRunCommand command16,
            GetRunCommand command17,
            ModifyRunCommand command18,
            CancelRunCommand command19,
            ListRunStepsCommand command20,
            GetRunStepCommand command21,
            SubmitToolOuputsToRunCommand command22)
            : base(
                name: "assistant")
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
            Subcommands.Add(command20);
            Subcommands.Add(command21);
            Subcommands.Add(command22);
        }
    }
}
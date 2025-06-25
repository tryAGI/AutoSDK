//HintName: G.Commands.CallCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallCommand : global::System.CommandLine.Command
    {
        public CallCommand(
            CallsListCommand command0,
            CallsCreateCommand command1,
            CallsRetrieveCommand command2,
            CallsDestroyCommand command3,
            CallsMessagesListCommand command4,
            CallsRecordingRetrieveCommand command5,
            CallsStagesListCommand command6,
            CallsStagesRetrieveCommand command7,
            CallsStagesMessagesListCommand command8,
            CallsStagesMessagesAudioRetrieveCommand command9,
            CallsStagesToolsListCommand command10,
            CallsToolsListCommand command11)
            : base(
                name: "call")
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
        }
    }
}
//HintName: G.Commands.CallGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallGroupCommand : global::System.CommandLine.Command
    {
        public CallGroupCommand(
            CallsCallsCreateCommand command0,
            CallsCallsDestroyCommand command1,
            CallsCallsListCommand command2,
            CallsCallsMessagesListCommand command3,
            CallsCallsRecordingRetrieveCommand command4,
            CallsCallsRetrieveCommand command5,
            CallsCallsStagesListCommand command6,
            CallsCallsStagesMessagesAudioRetrieveCommand command7,
            CallsCallsStagesMessagesListCommand command8,
            CallsCallsStagesRetrieveCommand command9,
            CallsCallsStagesToolsListCommand command10,
            CallsCallsToolsListCommand command11)
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
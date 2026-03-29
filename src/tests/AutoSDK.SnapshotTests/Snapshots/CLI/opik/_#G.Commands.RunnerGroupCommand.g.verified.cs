//HintName: G.Commands.RunnerGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnerGroupCommand : global::System.CommandLine.Command
    {
        public RunnerGroupCommand(
            RunnersAppendJobLogsCommand command0,
            RunnersCancelJobCommand command1,
            RunnersConnectRunnerCommand command2,
            RunnersCreateJobCommand command3,
            RunnersGeneratePairingCodeCommand command4,
            RunnersGetJobCommand command5,
            RunnersGetJobLogsCommand command6,
            RunnersGetRunnerCommand command7,
            RunnersHeartbeatCommand command8,
            RunnersListJobsCommand command9,
            RunnersListRunnersCommand command10,
            RunnersNextJobCommand command11,
            RunnersRegisterAgentsCommand command12,
            RunnersReportJobResultCommand command13)
            : base(
                name: "runner")
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
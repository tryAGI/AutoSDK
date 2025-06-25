//HintName: G.Commands.FineTuningCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FineTuningCommand : global::System.CommandLine.Command
    {
        public FineTuningCommand(
            RunGraderCommand command0,
            ValidateGraderCommand command1,
            ListFineTuningCheckpointPermissionsCommand command2,
            CreateFineTuningCheckpointPermissionCommand command3,
            DeleteFineTuningCheckpointPermissionCommand command4,
            CreateFineTuningJobCommand command5,
            ListPaginatedFineTuningJobsCommand command6,
            RetrieveFineTuningJobCommand command7,
            CancelFineTuningJobCommand command8,
            ListFineTuningJobCheckpointsCommand command9,
            ListFineTuningEventsCommand command10,
            PauseFineTuningJobCommand command11,
            ResumeFineTuningJobCommand command12)
            : base(
                name: "finetuning")
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
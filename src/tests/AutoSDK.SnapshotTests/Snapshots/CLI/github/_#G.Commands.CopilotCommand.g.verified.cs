//HintName: G.Commands.CopilotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CopilotCommand : global::System.CommandLine.Command
    {
        public CopilotCommand(
            CopilotListCopilotSeatsForEnterpriseCommand command0,
            CopilotUsageMetricsForEnterpriseCommand command1,
            CopilotUsageMetricsForEnterpriseTeamCommand command2,
            CopilotGetCopilotOrganizationDetailsCommand command3,
            CopilotListCopilotSeatsCommand command4,
            CopilotAddCopilotSeatsForTeamsCommand command5,
            CopilotCancelCopilotSeatAssignmentForTeamsCommand command6,
            CopilotAddCopilotSeatsForUsersCommand command7,
            CopilotCancelCopilotSeatAssignmentForUsersCommand command8,
            CopilotUsageMetricsForOrgCommand command9,
            CopilotGetCopilotSeatDetailsForUserCommand command10,
            CopilotUsageMetricsForTeamCommand command11)
            : base(
                name: "copilot")
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
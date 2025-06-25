//HintName: G.Commands.SecurityAdvisoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoryCommand : global::System.CommandLine.Command
    {
        public SecurityAdvisoryCommand(
            SecurityAdvisoriesListGlobalAdvisoriesCommand command0,
            SecurityAdvisoriesGetGlobalAdvisoryCommand command1,
            SecurityAdvisoriesListOrgRepositoryAdvisoriesCommand command2,
            SecurityAdvisoriesListRepositoryAdvisoriesCommand command3,
            SecurityAdvisoriesCreateRepositoryAdvisoryCommand command4,
            SecurityAdvisoriesCreatePrivateVulnerabilityReportCommand command5,
            SecurityAdvisoriesGetRepositoryAdvisoryCommand command6,
            SecurityAdvisoriesUpdateRepositoryAdvisoryCommand command7,
            SecurityAdvisoriesCreateRepositoryAdvisoryCveRequestCommand command8,
            SecurityAdvisoriesCreateForkCommand command9)
            : base(
                name: "securityadvisory")
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
        }
    }
}
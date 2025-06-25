//HintName: G.Commands.CodeSecurityCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeSecurityCommand : global::System.CommandLine.Command
    {
        public CodeSecurityCommand(
            CodeSecurityGetConfigurationsForOrgCommand command0,
            CodeSecurityCreateConfigurationCommand command1,
            CodeSecurityGetDefaultConfigurationsCommand command2,
            CodeSecurityDetachConfigurationCommand command3,
            CodeSecurityGetConfigurationCommand command4,
            CodeSecurityUpdateConfigurationCommand command5,
            CodeSecurityDeleteConfigurationCommand command6,
            CodeSecurityAttachConfigurationCommand command7,
            CodeSecuritySetConfigurationAsDefaultCommand command8,
            CodeSecurityGetRepositoriesForConfigurationCommand command9,
            CodeSecurityGetConfigurationForRepositoryCommand command10)
            : base(
                name: "codesecurity")
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
        }
    }
}
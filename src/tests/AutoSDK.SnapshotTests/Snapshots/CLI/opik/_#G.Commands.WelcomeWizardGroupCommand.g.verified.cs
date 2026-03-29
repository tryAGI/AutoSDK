//HintName: G.Commands.WelcomeWizardGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WelcomeWizardGroupCommand : global::System.CommandLine.Command
    {
        public WelcomeWizardGroupCommand(
            WelcomeWizardGetWelcomeWizardStatusCommand command0,
            WelcomeWizardSubmitWelcomeWizardCommand command1)
            : base(
                name: "welcomewizard")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
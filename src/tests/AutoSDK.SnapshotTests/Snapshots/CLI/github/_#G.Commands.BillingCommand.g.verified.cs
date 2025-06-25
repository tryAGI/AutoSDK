//HintName: G.Commands.BillingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BillingCommand : global::System.CommandLine.Command
    {
        public BillingCommand(
            BillingGetGithubActionsBillingOrgCommand command0,
            BillingGetGithubPackagesBillingOrgCommand command1,
            BillingGetSharedStorageBillingOrgCommand command2,
            BillingGetGithubActionsBillingUserCommand command3,
            BillingGetGithubPackagesBillingUserCommand command4,
            BillingGetSharedStorageBillingUserCommand command5)
            : base(
                name: "billing")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}
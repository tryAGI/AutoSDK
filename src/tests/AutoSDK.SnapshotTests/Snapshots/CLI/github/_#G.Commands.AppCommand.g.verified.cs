//HintName: G.Commands.AppCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppCommand : global::System.CommandLine.Command
    {
        public AppCommand(
            AppsGetAuthenticatedCommand command0,
            AppsCreateFromManifestCommand command1,
            AppsGetWebhookConfigForAppCommand command2,
            AppsUpdateWebhookConfigForAppCommand command3,
            AppsListWebhookDeliveriesCommand command4,
            AppsGetWebhookDeliveryCommand command5,
            AppsRedeliverWebhookDeliveryCommand command6,
            AppsListInstallationRequestsForAuthenticatedAppCommand command7,
            AppsListInstallationsCommand command8,
            AppsGetInstallationCommand command9,
            AppsDeleteInstallationCommand command10,
            AppsCreateInstallationAccessTokenCommand command11,
            AppsSuspendInstallationCommand command12,
            AppsUnsuspendInstallationCommand command13,
            AppsDeleteAuthorizationCommand command14,
            AppsCheckTokenCommand command15,
            AppsResetTokenCommand command16,
            AppsDeleteTokenCommand command17,
            AppsScopeTokenCommand command18,
            AppsGetBySlugCommand command19,
            AppsListReposAccessibleToInstallationCommand command20,
            AppsRevokeInstallationAccessTokenCommand command21,
            AppsGetSubscriptionPlanForAccountCommand command22,
            AppsListPlansCommand command23,
            AppsListAccountsForPlanCommand command24,
            AppsGetSubscriptionPlanForAccountStubbedCommand command25,
            AppsListPlansStubbedCommand command26,
            AppsListAccountsForPlanStubbedCommand command27,
            AppsGetOrgInstallationCommand command28,
            AppsGetRepoInstallationCommand command29,
            AppsListInstallationsForAuthenticatedUserCommand command30,
            AppsListInstallationReposForAuthenticatedUserCommand command31,
            AppsAddRepoToInstallationForAuthenticatedUserCommand command32,
            AppsRemoveRepoFromInstallationForAuthenticatedUserCommand command33,
            AppsListSubscriptionsForAuthenticatedUserCommand command34,
            AppsListSubscriptionsForAuthenticatedUserStubbedCommand command35,
            AppsGetUserInstallationCommand command36)
            : base(
                name: "app")
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
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
            Subcommands.Add(command27);
            Subcommands.Add(command28);
            Subcommands.Add(command29);
            Subcommands.Add(command30);
            Subcommands.Add(command31);
            Subcommands.Add(command32);
            Subcommands.Add(command33);
            Subcommands.Add(command34);
            Subcommands.Add(command35);
            Subcommands.Add(command36);
        }
    }
}
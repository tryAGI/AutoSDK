//HintName: G.Commands.UserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UserCommand : global::System.CommandLine.Command
    {
        public UserCommand(
            UsersGetAuthenticatedCommand command0,
            UsersUpdateAuthenticatedCommand command1,
            UsersListBlockedByAuthenticatedUserCommand command2,
            UsersCheckBlockedCommand command3,
            UsersBlockCommand command4,
            UsersUnblockCommand command5,
            UsersSetPrimaryEmailVisibilityForAuthenticatedUserCommand command6,
            UsersListEmailsForAuthenticatedUserCommand command7,
            UsersAddEmailForAuthenticatedUserCommand command8,
            UsersDeleteEmailForAuthenticatedUserCommand command9,
            UsersListFollowersForAuthenticatedUserCommand command10,
            UsersListFollowedByAuthenticatedUserCommand command11,
            UsersCheckPersonIsFollowedByAuthenticatedCommand command12,
            UsersFollowCommand command13,
            UsersUnfollowCommand command14,
            UsersListGpgKeysForAuthenticatedUserCommand command15,
            UsersCreateGpgKeyForAuthenticatedUserCommand command16,
            UsersGetGpgKeyForAuthenticatedUserCommand command17,
            UsersDeleteGpgKeyForAuthenticatedUserCommand command18,
            UsersListPublicSshKeysForAuthenticatedUserCommand command19,
            UsersCreatePublicSshKeyForAuthenticatedUserCommand command20,
            UsersGetPublicSshKeyForAuthenticatedUserCommand command21,
            UsersDeletePublicSshKeyForAuthenticatedUserCommand command22,
            UsersListPublicEmailsForAuthenticatedUserCommand command23,
            UsersListSocialAccountsForAuthenticatedUserCommand command24,
            UsersAddSocialAccountForAuthenticatedUserCommand command25,
            UsersDeleteSocialAccountForAuthenticatedUserCommand command26,
            UsersListSshSigningKeysForAuthenticatedUserCommand command27,
            UsersCreateSshSigningKeyForAuthenticatedUserCommand command28,
            UsersGetSshSigningKeyForAuthenticatedUserCommand command29,
            UsersDeleteSshSigningKeyForAuthenticatedUserCommand command30,
            UsersGetByIdCommand command31,
            UsersListCommand command32,
            UsersGetByUsernameCommand command33,
            UsersListAttestationsCommand command34,
            UsersListFollowersForUserCommand command35,
            UsersListFollowingForUserCommand command36,
            UsersCheckFollowingForUserCommand command37,
            UsersListGpgKeysForUserCommand command38,
            UsersGetContextForUserCommand command39,
            UsersListPublicKeysForUserCommand command40,
            UsersListSocialAccountsForUserCommand command41,
            UsersListSshSigningKeysForUserCommand command42)
            : base(
                name: "user")
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
            Subcommands.Add(command37);
            Subcommands.Add(command38);
            Subcommands.Add(command39);
            Subcommands.Add(command40);
            Subcommands.Add(command41);
            Subcommands.Add(command42);
        }
    }
}
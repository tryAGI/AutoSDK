//HintName: G.Commands.NamespaceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class NamespaceGroupCommand : global::System.CommandLine.Command
    {
        public NamespaceGroupCommand(
            NamespaceCheckNamespaceCommand command0,
            NamespaceCreateOrganizationCommand command1,
            NamespaceCreateTokenCommand command2,
            NamespaceDeleteOrganizationCommand command3,
            NamespaceDeleteOrganizationMembershipCommand command4,
            NamespaceDeleteTokenCommand command5,
            NamespaceDeleteUserMembershipCommand command6,
            NamespaceGetAuthenticatedUserCommand command7,
            NamespaceGetOrganizationCommand command8,
            NamespaceGetOrganizationMembershipCommand command9,
            NamespaceGetTokenCommand command10,
            NamespaceGetUserCommand command11,
            NamespaceGetUserMembershipCommand command12,
            NamespaceListOrganizationMembershipsCommand command13,
            NamespaceListOrganizationsCommand command14,
            NamespaceListTokensCommand command15,
            NamespaceListUserMembershipsCommand command16,
            NamespaceListUsersCommand command17,
            NamespacePatchAuthenticatedUserCommand command18,
            NamespaceUpdateOrganizationCommand command19,
            NamespaceUpdateOrganizationMembershipCommand command20,
            NamespaceUpdateUserMembershipCommand command21,
            NamespaceValidateTokenCommand command22)
            : base(
                name: "namespace")
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
        }
    }
}
//HintName: G.Commands.NamespaceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class NamespaceGroupCommand : global::System.CommandLine.Command
    {
        public NamespaceGroupCommand(
            NamespaceGetAuthenticatedUserCommand command0,
            NamespacePatchAuthenticatedUserCommand command1,
            NamespaceListUsersCommand command2,
            NamespaceGetUserCommand command3,
            NamespaceListOrganizationsCommand command4,
            NamespaceCreateOrganizationCommand command5,
            NamespaceGetOrganizationCommand command6,
            NamespaceDeleteOrganizationCommand command7,
            NamespaceUpdateOrganizationCommand command8,
            NamespaceListUserMembershipsCommand command9,
            NamespaceGetUserMembershipCommand command10,
            NamespaceUpdateUserMembershipCommand command11,
            NamespaceDeleteUserMembershipCommand command12,
            NamespaceListOrganizationMembershipsCommand command13,
            NamespaceGetOrganizationMembershipCommand command14,
            NamespaceUpdateOrganizationMembershipCommand command15,
            NamespaceDeleteOrganizationMembershipCommand command16,
            NamespaceListTokensCommand command17,
            NamespaceCreateTokenCommand command18,
            NamespaceGetTokenCommand command19,
            NamespaceDeleteTokenCommand command20,
            NamespaceValidateTokenCommand command21,
            NamespaceCheckNamespaceCommand command22)
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
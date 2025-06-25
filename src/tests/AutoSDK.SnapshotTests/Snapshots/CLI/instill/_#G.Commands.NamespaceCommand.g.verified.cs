//HintName: G.Commands.NamespaceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class NamespaceCommand : global::System.CommandLine.Command
    {
        public NamespaceCommand(
            GetAuthenticatedUserCommand command0,
            PatchAuthenticatedUserCommand command1,
            ListUsersCommand command2,
            GetUserCommand command3,
            ListOrganizationsCommand command4,
            CreateOrganizationCommand command5,
            GetOrganizationCommand command6,
            DeleteOrganizationCommand command7,
            UpdateOrganizationCommand command8,
            ListUserMembershipsCommand command9,
            GetUserMembershipCommand command10,
            UpdateUserMembershipCommand command11,
            DeleteUserMembershipCommand command12,
            ListOrganizationMembershipsCommand command13,
            GetOrganizationMembershipCommand command14,
            UpdateOrganizationMembershipCommand command15,
            DeleteOrganizationMembershipCommand command16,
            ListTokensCommand command17,
            CreateTokenCommand command18,
            GetTokenCommand command19,
            DeleteTokenCommand command20,
            ValidateTokenCommand command21,
            CheckNamespaceCommand command22)
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
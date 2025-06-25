//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            ActionCommand command0,
            ActivityCommand command1,
            AppCommand command2,
            BillingCommand command3,
            CheckCommand command4,
            CodeScanningCommand command5,
            CodesOfConductCommand command6,
            EmojiCommand command7,
            DependabotCommand command8,
            DependencyGraphCommand command9,
            GistCommand command10,
            GitCommand command11,
            GitignoreCommand command12,
            IssueCommand command13,
            LicenseCommand command14,
            MarkdownCommand command15,
            MergeQueueCommand command16,
            MetaCommand command17,
            MigrationCommand command18,
            OidcCommand command19,
            OrgCommand command20,
            PackageCommand command21,
            ProjectCommand command22,
            PullCommand command23,
            RateLimitCommand command24,
            ReactionCommand command25,
            RepoCommand command26,
            SearchCommand command27,
            SecretScanningCommand command28,
            TeamCommand command29,
            UserCommand command30,
            CodespaceCommand command31,
            CopilotCommand command32,
            SecurityAdvisoryCommand command33,
            InteractionCommand command34,
            ClassroomCommand command35,
            DesktopCommand command36,
            EnterpriseTeamCommand command37,
            CodeSecurityCommand command38)
            : base(
                description: "CLI tool")
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
        }
    }
}
//HintName: G.Commands.ManageGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageGroupCommand : global::System.CommandLine.Command
    {
        public ManageGroupCommand(
            GetApiKeysCommand command0,
            CreateApiKeyCommand command1,
            DeleteSingleApiKeyCommand command2,
            ReactivateSubscriptionCommand command3,
            GetApiStripeSubscriptionCommand command4,
            GetApiSubscriptionCommand command5,
            PostApiSubscriptionCommand command6,
            GetApiTermsCommand command7,
            PostApiTermsCommand command8)
            : base(
                name: "manage")
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
        }
    }
}
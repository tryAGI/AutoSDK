//HintName: G.Commands.ManageGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageGroupCommand : global::System.CommandLine.Command
    {
        public ManageGroupCommand(
            ManageCreateApiKeyCommand command0,
            ManageDeleteSingleApiKeyCommand command1,
            ManageGetApiKeysCommand command2,
            ManageGetApiStripeSubscriptionCommand command3,
            ManageGetApiSubscriptionCommand command4,
            ManageGetApiTermsCommand command5,
            ManagePostApiSubscriptionCommand command6,
            ManagePostApiTermsCommand command7,
            ManageReactivateSubscriptionCommand command8)
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
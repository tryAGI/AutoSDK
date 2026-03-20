//HintName: G.Commands.ManageGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageGroupCommand : global::System.CommandLine.Command
    {
        public ManageGroupCommand(
            ManageGetApiKeysCommand command0,
            ManageCreateApiKeyCommand command1,
            ManageDeleteSingleApiKeyCommand command2,
            ManageReactivateSubscriptionCommand command3,
            ManageGetApiStripeSubscriptionCommand command4,
            ManageGetApiSubscriptionCommand command5,
            ManagePostApiSubscriptionCommand command6,
            ManageGetApiTermsCommand command7,
            ManagePostApiTermsCommand command8)
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
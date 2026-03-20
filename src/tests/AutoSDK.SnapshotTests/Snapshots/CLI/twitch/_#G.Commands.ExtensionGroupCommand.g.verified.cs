//HintName: G.Commands.ExtensionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtensionGroupCommand : global::System.CommandLine.Command
    {
        public ExtensionGroupCommand(
            ExtensionsCreateExtensionSecretCommand command0,
            ExtensionsGetExtensionBitsProductsCommand command1,
            ExtensionsGetExtensionConfigurationSegmentCommand command2,
            ExtensionsGetExtensionLiveChannelsCommand command3,
            ExtensionsGetExtensionSecretsCommand command4,
            ExtensionsGetExtensionsCommand command5,
            ExtensionsGetReleasedExtensionsCommand command6,
            ExtensionsSendExtensionChatMessageCommand command7,
            ExtensionsSendExtensionPubsubMessageCommand command8,
            ExtensionsSetExtensionConfigurationSegmentCommand command9,
            ExtensionsSetExtensionRequiredConfigurationCommand command10,
            ExtensionsUpdateExtensionBitsProductCommand command11)
            : base(
                name: "extension")
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
        }
    }
}
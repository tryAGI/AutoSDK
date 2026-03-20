//HintName: G.Commands.ExtensionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtensionGroupCommand : global::System.CommandLine.Command
    {
        public ExtensionGroupCommand(
            ExtensionsGetExtensionConfigurationSegmentCommand command0,
            ExtensionsSetExtensionConfigurationSegmentCommand command1,
            ExtensionsSetExtensionRequiredConfigurationCommand command2,
            ExtensionsSendExtensionPubsubMessageCommand command3,
            ExtensionsGetExtensionLiveChannelsCommand command4,
            ExtensionsGetExtensionSecretsCommand command5,
            ExtensionsCreateExtensionSecretCommand command6,
            ExtensionsSendExtensionChatMessageCommand command7,
            ExtensionsGetExtensionsCommand command8,
            ExtensionsGetReleasedExtensionsCommand command9,
            ExtensionsGetExtensionBitsProductsCommand command10,
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
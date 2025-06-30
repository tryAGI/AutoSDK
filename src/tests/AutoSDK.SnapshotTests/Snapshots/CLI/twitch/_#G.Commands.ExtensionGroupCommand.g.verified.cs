//HintName: G.Commands.ExtensionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtensionGroupCommand : global::System.CommandLine.Command
    {
        public ExtensionGroupCommand(
            GetExtensionConfigurationSegmentCommand command0,
            SetExtensionConfigurationSegmentCommand command1,
            SetExtensionRequiredConfigurationCommand command2,
            SendExtensionPubsubMessageCommand command3,
            GetExtensionLiveChannelsCommand command4,
            GetExtensionSecretsCommand command5,
            CreateExtensionSecretCommand command6,
            SendExtensionChatMessageCommand command7,
            GetExtensionsCommand command8,
            GetReleasedExtensionsCommand command9,
            GetExtensionBitsProductsCommand command10,
            UpdateExtensionBitsProductCommand command11)
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
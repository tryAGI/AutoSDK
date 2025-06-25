//HintName: G.Commands.ModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelCommand : global::System.CommandLine.Command
    {
        public ModelCommand(
            ModelPublicServiceListModelDefinitionsCommand command0,
            ModelPublicServiceListAvailableRegionsCommand command1,
            ModelPublicServiceGetModelDefinitionCommand command2,
            ModelPublicServiceListModelsCommand command3,
            ModelPublicServiceListNamespaceModelsCommand command4,
            ModelPublicServiceCreateNamespaceModelCommand command5,
            ModelPublicServiceGetNamespaceModelCommand command6,
            ModelPublicServiceDeleteNamespaceModelCommand command7,
            ModelPublicServiceUpdateNamespaceModelCommand command8,
            ModelPublicServiceRenameNamespaceModelCommand command9,
            ModelPublicServiceWatchNamespaceModelCommand command10,
            ModelPublicServiceWatchNamespaceLatestModelCommand command11,
            ModelPublicServiceListNamespaceModelVersionsCommand command12,
            ModelPublicServiceDeleteNamespaceModelVersionCommand command13,
            ModelPublicServiceTriggerNamespaceModelCommand command14,
            ModelPublicServiceTriggerAsyncNamespaceModelCommand command15,
            ModelPublicServiceTriggerNamespaceLatestModelCommand command16,
            ModelPublicServiceTriggerAsyncNamespaceLatestModelCommand command17,
            ModelPublicServiceGetNamespaceModelOperationCommand command18,
            ModelPublicServiceGetNamespaceLatestModelOperationCommand command19,
            ModelPublicServiceGetModelOperationCommand command20,
            ModelPublicServiceListModelRunsCommand command21,
            ModelPublicServiceListModelRunsByRequesterCommand command22)
            : base(
                name: "model")
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
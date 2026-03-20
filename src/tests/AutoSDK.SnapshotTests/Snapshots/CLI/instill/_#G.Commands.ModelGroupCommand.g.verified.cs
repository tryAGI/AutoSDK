//HintName: G.Commands.ModelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelGroupCommand : global::System.CommandLine.Command
    {
        public ModelGroupCommand(
            ModelModelPublicServiceCreateNamespaceModelCommand command0,
            ModelModelPublicServiceDeleteNamespaceModelCommand command1,
            ModelModelPublicServiceDeleteNamespaceModelVersionCommand command2,
            ModelModelPublicServiceGetModelDefinitionCommand command3,
            ModelModelPublicServiceGetModelOperationCommand command4,
            ModelModelPublicServiceGetNamespaceLatestModelOperationCommand command5,
            ModelModelPublicServiceGetNamespaceModelCommand command6,
            ModelModelPublicServiceGetNamespaceModelOperationCommand command7,
            ModelModelPublicServiceListAvailableRegionsCommand command8,
            ModelModelPublicServiceListModelDefinitionsCommand command9,
            ModelModelPublicServiceListModelRunsCommand command10,
            ModelModelPublicServiceListModelRunsByRequesterCommand command11,
            ModelModelPublicServiceListModelsCommand command12,
            ModelModelPublicServiceListNamespaceModelVersionsCommand command13,
            ModelModelPublicServiceListNamespaceModelsCommand command14,
            ModelModelPublicServiceRenameNamespaceModelCommand command15,
            ModelModelPublicServiceTriggerAsyncNamespaceLatestModelCommand command16,
            ModelModelPublicServiceTriggerAsyncNamespaceModelCommand command17,
            ModelModelPublicServiceTriggerNamespaceLatestModelCommand command18,
            ModelModelPublicServiceTriggerNamespaceModelCommand command19,
            ModelModelPublicServiceUpdateNamespaceModelCommand command20,
            ModelModelPublicServiceWatchNamespaceLatestModelCommand command21,
            ModelModelPublicServiceWatchNamespaceModelCommand command22)
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
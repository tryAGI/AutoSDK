//HintName: G.Commands.ModelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelGroupCommand : global::System.CommandLine.Command
    {
        public ModelGroupCommand(
            ModelModelPublicServiceListModelDefinitionsCommand command0,
            ModelModelPublicServiceListAvailableRegionsCommand command1,
            ModelModelPublicServiceGetModelDefinitionCommand command2,
            ModelModelPublicServiceListModelsCommand command3,
            ModelModelPublicServiceListNamespaceModelsCommand command4,
            ModelModelPublicServiceCreateNamespaceModelCommand command5,
            ModelModelPublicServiceGetNamespaceModelCommand command6,
            ModelModelPublicServiceDeleteNamespaceModelCommand command7,
            ModelModelPublicServiceUpdateNamespaceModelCommand command8,
            ModelModelPublicServiceRenameNamespaceModelCommand command9,
            ModelModelPublicServiceWatchNamespaceModelCommand command10,
            ModelModelPublicServiceWatchNamespaceLatestModelCommand command11,
            ModelModelPublicServiceListNamespaceModelVersionsCommand command12,
            ModelModelPublicServiceDeleteNamespaceModelVersionCommand command13,
            ModelModelPublicServiceTriggerNamespaceModelCommand command14,
            ModelModelPublicServiceTriggerAsyncNamespaceModelCommand command15,
            ModelModelPublicServiceTriggerNamespaceLatestModelCommand command16,
            ModelModelPublicServiceTriggerAsyncNamespaceLatestModelCommand command17,
            ModelModelPublicServiceGetNamespaceModelOperationCommand command18,
            ModelModelPublicServiceGetNamespaceLatestModelOperationCommand command19,
            ModelModelPublicServiceGetModelOperationCommand command20,
            ModelModelPublicServiceListModelRunsCommand command21,
            ModelModelPublicServiceListModelRunsByRequesterCommand command22)
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
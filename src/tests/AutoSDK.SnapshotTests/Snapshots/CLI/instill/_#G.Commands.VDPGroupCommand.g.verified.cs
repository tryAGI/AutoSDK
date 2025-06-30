//HintName: G.Commands.VDPGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VDPGroupCommand : global::System.CommandLine.Command
    {
        public VDPGroupCommand(
            PipelinePublicServiceListPipelinesCommand command0,
            PipelinePublicServiceListNamespacePipelinesCommand command1,
            PipelinePublicServiceCreateNamespacePipelineCommand command2,
            PipelinePublicServiceGetNamespacePipelineCommand command3,
            PipelinePublicServiceDeleteNamespacePipelineCommand command4,
            PipelinePublicServiceUpdateNamespacePipelineCommand command5,
            PipelinePublicServiceValidateNamespacePipelineCommand command6,
            PipelinePublicServiceRenameNamespacePipelineCommand command7,
            PipelinePublicServiceCloneNamespacePipelineCommand command8,
            PipelinePublicServiceTriggerNamespacePipelineCommand command9,
            PipelinePublicServiceTriggerNamespacePipelineWithStreamCommand command10,
            PipelinePublicServiceTriggerAsyncNamespacePipelineCommand command11,
            PipelinePublicServiceListNamespacePipelineReleasesCommand command12,
            PipelinePublicServiceCreateNamespacePipelineReleaseCommand command13,
            PipelinePublicServiceGetNamespacePipelineReleaseCommand command14,
            PipelinePublicServiceDeleteNamespacePipelineReleaseCommand command15,
            PipelinePublicServiceUpdateNamespacePipelineReleaseCommand command16,
            PipelinePublicServiceCloneNamespacePipelineReleaseCommand command17,
            PipelinePublicServiceTriggerNamespacePipelineReleaseCommand command18,
            PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseCommand command19,
            PipelinePublicServiceListNamespaceSecretsCommand command20,
            PipelinePublicServiceCreateNamespaceSecretCommand command21,
            PipelinePublicServiceGetNamespaceSecretCommand command22,
            PipelinePublicServiceDeleteNamespaceSecretCommand command23,
            PipelinePublicServiceUpdateNamespaceSecretCommand command24,
            PipelinePublicServiceListComponentDefinitionsCommand command25,
            PipelinePublicServiceGetOperationCommand command26,
            PipelinePublicServiceListPipelineRunsCommand command27,
            PipelinePublicServiceListComponentRunsCommand command28,
            PipelinePublicServiceListPipelineRunsByRequesterCommand command29,
            PipelinePublicServiceListNamespaceConnectionsCommand command30,
            PipelinePublicServiceCreateNamespaceConnectionCommand command31,
            PipelinePublicServiceGetNamespaceConnectionCommand command32,
            PipelinePublicServiceDeleteNamespaceConnectionCommand command33,
            PipelinePublicServiceUpdateNamespaceConnectionCommand command34,
            PipelinePublicServiceTestNamespaceConnectionCommand command35,
            PipelinePublicServiceListPipelineIDsByConnectionIDCommand command36,
            PipelinePublicServiceListIntegrationsCommand command37,
            PipelinePublicServiceGetIntegrationCommand command38)
            : base(
                name: "vdp")
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
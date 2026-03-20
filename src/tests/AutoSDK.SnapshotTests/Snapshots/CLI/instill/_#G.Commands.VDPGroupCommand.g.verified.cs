//HintName: G.Commands.VdpGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VdpGroupCommand : global::System.CommandLine.Command
    {
        public VdpGroupCommand(
            VdpPipelinePublicServiceListPipelinesCommand command0,
            VdpPipelinePublicServiceListNamespacePipelinesCommand command1,
            VdpPipelinePublicServiceCreateNamespacePipelineCommand command2,
            VdpPipelinePublicServiceGetNamespacePipelineCommand command3,
            VdpPipelinePublicServiceDeleteNamespacePipelineCommand command4,
            VdpPipelinePublicServiceUpdateNamespacePipelineCommand command5,
            VdpPipelinePublicServiceValidateNamespacePipelineCommand command6,
            VdpPipelinePublicServiceRenameNamespacePipelineCommand command7,
            VdpPipelinePublicServiceCloneNamespacePipelineCommand command8,
            VdpPipelinePublicServiceTriggerNamespacePipelineCommand command9,
            VdpPipelinePublicServiceTriggerNamespacePipelineWithStreamCommand command10,
            VdpPipelinePublicServiceTriggerAsyncNamespacePipelineCommand command11,
            VdpPipelinePublicServiceListNamespacePipelineReleasesCommand command12,
            VdpPipelinePublicServiceCreateNamespacePipelineReleaseCommand command13,
            VdpPipelinePublicServiceGetNamespacePipelineReleaseCommand command14,
            VdpPipelinePublicServiceDeleteNamespacePipelineReleaseCommand command15,
            VdpPipelinePublicServiceUpdateNamespacePipelineReleaseCommand command16,
            VdpPipelinePublicServiceCloneNamespacePipelineReleaseCommand command17,
            VdpPipelinePublicServiceTriggerNamespacePipelineReleaseCommand command18,
            VdpPipelinePublicServiceTriggerAsyncNamespacePipelineReleaseCommand command19,
            VdpPipelinePublicServiceListNamespaceSecretsCommand command20,
            VdpPipelinePublicServiceCreateNamespaceSecretCommand command21,
            VdpPipelinePublicServiceGetNamespaceSecretCommand command22,
            VdpPipelinePublicServiceDeleteNamespaceSecretCommand command23,
            VdpPipelinePublicServiceUpdateNamespaceSecretCommand command24,
            VdpPipelinePublicServiceListComponentDefinitionsCommand command25,
            VdpPipelinePublicServiceGetOperationCommand command26,
            VdpPipelinePublicServiceListPipelineRunsCommand command27,
            VdpPipelinePublicServiceListComponentRunsCommand command28,
            VdpPipelinePublicServiceListPipelineRunsByRequesterCommand command29,
            VdpPipelinePublicServiceListNamespaceConnectionsCommand command30,
            VdpPipelinePublicServiceCreateNamespaceConnectionCommand command31,
            VdpPipelinePublicServiceGetNamespaceConnectionCommand command32,
            VdpPipelinePublicServiceDeleteNamespaceConnectionCommand command33,
            VdpPipelinePublicServiceUpdateNamespaceConnectionCommand command34,
            VdpPipelinePublicServiceTestNamespaceConnectionCommand command35,
            VdpPipelinePublicServiceListPipelineIDsByConnectionIDCommand command36,
            VdpPipelinePublicServiceListIntegrationsCommand command37,
            VdpPipelinePublicServiceGetIntegrationCommand command38)
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
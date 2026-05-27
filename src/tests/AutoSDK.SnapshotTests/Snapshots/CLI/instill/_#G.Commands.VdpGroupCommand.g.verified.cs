//HintName: G.Commands.VdpGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VdpGroupCommand : global::System.CommandLine.Command
    {
        public VdpGroupCommand(
            VdpPipelinePublicServiceCloneNamespacePipelineCommand command0,
            VdpPipelinePublicServiceCloneNamespacePipelineReleaseCommand command1,
            VdpPipelinePublicServiceCreateNamespaceConnectionCommand command2,
            VdpPipelinePublicServiceCreateNamespacePipelineCommand command3,
            VdpPipelinePublicServiceCreateNamespacePipelineReleaseCommand command4,
            VdpPipelinePublicServiceCreateNamespaceSecretCommand command5,
            VdpPipelinePublicServiceDeleteNamespaceConnectionCommand command6,
            VdpPipelinePublicServiceDeleteNamespacePipelineCommand command7,
            VdpPipelinePublicServiceDeleteNamespacePipelineReleaseCommand command8,
            VdpPipelinePublicServiceDeleteNamespaceSecretCommand command9,
            VdpPipelinePublicServiceGetIntegrationCommand command10,
            VdpPipelinePublicServiceGetNamespaceConnectionCommand command11,
            VdpPipelinePublicServiceGetNamespacePipelineCommand command12,
            VdpPipelinePublicServiceGetNamespacePipelineReleaseCommand command13,
            VdpPipelinePublicServiceGetNamespaceSecretCommand command14,
            VdpPipelinePublicServiceGetOperationCommand command15,
            VdpPipelinePublicServiceListComponentDefinitionsCommand command16,
            VdpPipelinePublicServiceListComponentRunsCommand command17,
            VdpPipelinePublicServiceListIntegrationsCommand command18,
            VdpPipelinePublicServiceListNamespaceConnectionsCommand command19,
            VdpPipelinePublicServiceListNamespacePipelineReleasesCommand command20,
            VdpPipelinePublicServiceListNamespacePipelinesCommand command21,
            VdpPipelinePublicServiceListNamespaceSecretsCommand command22,
            VdpPipelinePublicServiceListPipelineIDsByConnectionIDCommand command23,
            VdpPipelinePublicServiceListPipelineRunsCommand command24,
            VdpPipelinePublicServiceListPipelineRunsByRequesterCommand command25,
            VdpPipelinePublicServiceListPipelinesCommand command26,
            VdpPipelinePublicServiceRenameNamespacePipelineCommand command27,
            VdpPipelinePublicServiceTestNamespaceConnectionCommand command28,
            VdpPipelinePublicServiceTriggerAsyncNamespacePipelineCommand command29,
            VdpPipelinePublicServiceTriggerAsyncNamespacePipelineReleaseCommand command30,
            VdpPipelinePublicServiceTriggerNamespacePipelineCommand command31,
            VdpPipelinePublicServiceTriggerNamespacePipelineReleaseCommand command32,
            VdpPipelinePublicServiceTriggerNamespacePipelineWithStreamCommand command33,
            VdpPipelinePublicServiceUpdateNamespaceConnectionCommand command34,
            VdpPipelinePublicServiceUpdateNamespacePipelineCommand command35,
            VdpPipelinePublicServiceUpdateNamespacePipelineReleaseCommand command36,
            VdpPipelinePublicServiceUpdateNamespaceSecretCommand command37,
            VdpPipelinePublicServiceValidateNamespacePipelineCommand command38)
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
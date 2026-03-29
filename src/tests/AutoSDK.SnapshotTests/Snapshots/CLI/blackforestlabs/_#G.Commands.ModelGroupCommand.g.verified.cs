//HintName: G.Commands.ModelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelGroupCommand : global::System.CommandLine.Command
    {
        public ModelGroupCommand(
            ModelsExpandV1FluxPro10ExpandPostCommand command0,
            ModelsFillV1FluxPro10FillPostCommand command1,
            ModelsFluxDevV1FluxDevPostCommand command2,
            ModelsFluxPro10FillFinetunedV1FluxPro10FillFinetunedPostCommand command3,
            ModelsFluxPro11V1FluxPro11PostCommand command4,
            ModelsGenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostCommand command5,
            ModelsGenerateFlux11UltraV1FluxPro11UltraPostCommand command6,
            ModelsGenerateFlux2FlexV1Flux2FlexPostCommand command7,
            ModelsGenerateFlux2Klein4bV1Flux2Klein4bPostCommand command8,
            ModelsGenerateFlux2Klein9bKvV1Flux2Klein9bPreviewPostCommand command9,
            ModelsGenerateFlux2Klein9bV1Flux2Klein9bPostCommand command10,
            ModelsGenerateFlux2MaxV1Flux2MaxPostCommand command11,
            ModelsGenerateFlux2ProPreviewV1Flux2ProPreviewPostCommand command12,
            ModelsGenerateFlux2ProV1Flux2ProPostCommand command13,
            ModelsGenerateFluxKontextMaxV1FluxKontextMaxPostCommand command14,
            ModelsGenerateFluxKontextProV1FluxKontextProPostCommand command15)
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
        }
    }
}
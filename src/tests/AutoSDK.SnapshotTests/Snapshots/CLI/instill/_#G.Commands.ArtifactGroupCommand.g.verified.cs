//HintName: G.Commands.ArtifactGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ArtifactGroupCommand : global::System.CommandLine.Command
    {
        public ArtifactGroupCommand(
            ArtifactListCatalogsCommand command0,
            ArtifactCreateCatalogCommand command1,
            ArtifactGetFileCatalogCommand command2,
            ArtifactUpdateCatalogCommand command3,
            ArtifactDeleteCatalogCommand command4,
            ArtifactListCatalogFilesCommand command5,
            ArtifactUploadCatalogFileCommand command6,
            ArtifactDeleteCatalogFileCommand command7,
            ArtifactProcessCatalogFilesCommand command8,
            ArtifactListChunksCommand command9,
            ArtifactGetSourceFileCommand command10,
            ArtifactUpdateChunkCommand command11,
            ArtifactSimilarityChunksSearchCommand command12,
            ArtifactQuestionAnsweringCommand command13,
            ArtifactListCatalogRunsCommand command14,
            ArtifactGetObjectUploadURLCommand command15,
            ArtifactGetObjectDownloadURLCommand command16)
            : base(
                name: "artifact")
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
        }
    }
}
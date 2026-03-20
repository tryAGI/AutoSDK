//HintName: G.Commands.ArtifactGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ArtifactGroupCommand : global::System.CommandLine.Command
    {
        public ArtifactGroupCommand(
            ArtifactCreateCatalogCommand command0,
            ArtifactDeleteCatalogCommand command1,
            ArtifactDeleteCatalogFileCommand command2,
            ArtifactGetFileCatalogCommand command3,
            ArtifactGetObjectDownloadURLCommand command4,
            ArtifactGetObjectUploadURLCommand command5,
            ArtifactGetSourceFileCommand command6,
            ArtifactListCatalogFilesCommand command7,
            ArtifactListCatalogRunsCommand command8,
            ArtifactListCatalogsCommand command9,
            ArtifactListChunksCommand command10,
            ArtifactProcessCatalogFilesCommand command11,
            ArtifactQuestionAnsweringCommand command12,
            ArtifactSimilarityChunksSearchCommand command13,
            ArtifactUpdateCatalogCommand command14,
            ArtifactUpdateChunkCommand command15,
            ArtifactUploadCatalogFileCommand command16)
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
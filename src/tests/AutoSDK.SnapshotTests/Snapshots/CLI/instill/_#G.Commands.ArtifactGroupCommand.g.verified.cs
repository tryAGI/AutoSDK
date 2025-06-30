//HintName: G.Commands.ArtifactGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ArtifactGroupCommand : global::System.CommandLine.Command
    {
        public ArtifactGroupCommand(
            ListCatalogsCommand command0,
            CreateCatalogCommand command1,
            GetFileCatalogCommand command2,
            UpdateCatalogCommand command3,
            DeleteCatalogCommand command4,
            ListCatalogFilesCommand command5,
            UploadCatalogFileCommand command6,
            DeleteCatalogFileCommand command7,
            ProcessCatalogFilesCommand command8,
            ListChunksCommand command9,
            GetSourceFileCommand command10,
            UpdateChunkCommand command11,
            SimilarityChunksSearchCommand command12,
            QuestionAnsweringCommand command13,
            ListCatalogRunsCommand command14,
            GetObjectUploadURLCommand command15,
            GetObjectDownloadURLCommand command16)
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
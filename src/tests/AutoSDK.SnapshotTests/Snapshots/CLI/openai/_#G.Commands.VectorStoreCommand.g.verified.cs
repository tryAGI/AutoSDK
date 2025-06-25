//HintName: G.Commands.VectorStoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VectorStoreCommand : global::System.CommandLine.Command
    {
        public VectorStoreCommand(
            ListVectorStoresCommand command0,
            CreateVectorStoreCommand command1,
            GetVectorStoreCommand command2,
            ModifyVectorStoreCommand command3,
            DeleteVectorStoreCommand command4,
            CreateVectorStoreFileBatchCommand command5,
            GetVectorStoreFileBatchCommand command6,
            CancelVectorStoreFileBatchCommand command7,
            ListFilesInVectorStoreBatchCommand command8,
            ListVectorStoreFilesCommand command9,
            CreateVectorStoreFileCommand command10,
            GetVectorStoreFileCommand command11,
            DeleteVectorStoreFileCommand command12,
            UpdateVectorStoreFileAttributesCommand command13,
            RetrieveVectorStoreFileContentCommand command14,
            SearchVectorStoreCommand command15)
            : base(
                name: "vectorstore")
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
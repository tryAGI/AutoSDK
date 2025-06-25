//HintName: G.Commands.Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Command : global::System.CommandLine.Command
    {
        public Command(
            ListContainersCommand command0,
            CreateContainerCommand command1,
            RetrieveContainerCommand command2,
            DeleteContainerCommand command3,
            CreateContainerFileCommand command4,
            ListContainerFilesCommand command5,
            RetrieveContainerFileCommand command6,
            DeleteContainerFileCommand command7,
            RetrieveContainerFileContentCommand command8,
            AdminApiKeysListCommand command9,
            AdminApiKeysCreateCommand command10,
            AdminApiKeysGetCommand command11,
            AdminApiKeysDeleteCommand command12)
            : base(
                name: "")
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
        }
    }
}
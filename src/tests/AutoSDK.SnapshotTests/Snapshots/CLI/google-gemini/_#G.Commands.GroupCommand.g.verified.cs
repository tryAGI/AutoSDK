//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            ListModelsCommand command0,
            GetModelCommand command1,
            GenerateContentCommand command2,
            EmbedContentCommand command3,
            BatchEmbedContentsCommand command4,
            CountTokensCommand command5,
            GenerateContentTunedModelCommand command6,
            ListTunedModelOperationsCommand command7,
            GetTunedModelOperationCommand command8,
            CancelTunedModelOperationCommand command9,
            ListOperationsCommand command10,
            DeleteOperationCommand command11)
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
        }
    }
}
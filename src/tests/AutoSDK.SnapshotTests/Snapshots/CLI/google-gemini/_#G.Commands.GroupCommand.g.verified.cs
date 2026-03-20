//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            BatchEmbedContentsCommand command0,
            CancelTunedModelOperationCommand command1,
            CountTokensCommand command2,
            DeleteOperationCommand command3,
            EmbedContentCommand command4,
            GenerateContentCommand command5,
            GenerateContentTunedModelCommand command6,
            GetModelCommand command7,
            GetTunedModelOperationCommand command8,
            ListModelsCommand command9,
            ListOperationsCommand command10,
            ListTunedModelOperationsCommand command11)
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
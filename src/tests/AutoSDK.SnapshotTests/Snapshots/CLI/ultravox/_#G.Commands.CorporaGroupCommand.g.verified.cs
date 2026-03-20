//HintName: G.Commands.CorporaGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaGroupCommand : global::System.CommandLine.Command
    {
        public CorporaGroupCommand(
            CorporaCorporaListCommand command0,
            CorporaCorporaCreateCommand command1,
            CorporaCorporaRetrieveCommand command2,
            CorporaCorporaUpdateCommand command3,
            CorporaCorporaPartialUpdateCommand command4,
            CorporaCorporaDestroyCommand command5,
            CorporaCorporaQueryCommand command6,
            CorporaCorporaSourcesListCommand command7,
            CorporaCorporaSourcesCreateCommand command8,
            CorporaCorporaSourcesRetrieveCommand command9,
            CorporaCorporaSourcesUpdateCommand command10,
            CorporaCorporaSourcesPartialUpdateCommand command11,
            CorporaCorporaSourcesDestroyCommand command12,
            CorporaCorporaSourcesDocumentsListCommand command13,
            CorporaCorporaSourcesDocumentsRetrieveCommand command14,
            CorporaCorporaUploadsCreateCommand command15)
            : base(
                name: "corpora")
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
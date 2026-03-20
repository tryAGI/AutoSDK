//HintName: G.Commands.CorporaGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaGroupCommand : global::System.CommandLine.Command
    {
        public CorporaGroupCommand(
            CorporaCorporaCreateCommand command0,
            CorporaCorporaDestroyCommand command1,
            CorporaCorporaListCommand command2,
            CorporaCorporaPartialUpdateCommand command3,
            CorporaCorporaQueryCommand command4,
            CorporaCorporaRetrieveCommand command5,
            CorporaCorporaSourcesCreateCommand command6,
            CorporaCorporaSourcesDestroyCommand command7,
            CorporaCorporaSourcesDocumentsListCommand command8,
            CorporaCorporaSourcesDocumentsRetrieveCommand command9,
            CorporaCorporaSourcesListCommand command10,
            CorporaCorporaSourcesPartialUpdateCommand command11,
            CorporaCorporaSourcesRetrieveCommand command12,
            CorporaCorporaSourcesUpdateCommand command13,
            CorporaCorporaUpdateCommand command14,
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
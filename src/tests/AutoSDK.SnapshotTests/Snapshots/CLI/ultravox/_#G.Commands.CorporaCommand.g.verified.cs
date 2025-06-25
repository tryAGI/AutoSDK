//HintName: G.Commands.CorporaCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaCommand : global::System.CommandLine.Command
    {
        public CorporaCommand(
            CorporaListCommand command0,
            CorporaCreateCommand command1,
            CorporaRetrieveCommand command2,
            CorporaUpdateCommand command3,
            CorporaPartialUpdateCommand command4,
            CorporaDestroyCommand command5,
            CorporaQueryCommand command6,
            CorporaSourcesListCommand command7,
            CorporaSourcesCreateCommand command8,
            CorporaSourcesRetrieveCommand command9,
            CorporaSourcesUpdateCommand command10,
            CorporaSourcesPartialUpdateCommand command11,
            CorporaSourcesDestroyCommand command12,
            CorporaSourcesDocumentsListCommand command13,
            CorporaSourcesDocumentsRetrieveCommand command14,
            CorporaUploadsCreateCommand command15)
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
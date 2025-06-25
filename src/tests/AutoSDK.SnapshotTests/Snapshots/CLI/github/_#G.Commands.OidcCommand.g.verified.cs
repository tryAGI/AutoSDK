//HintName: G.Commands.OidcCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OidcCommand : global::System.CommandLine.Command
    {
        public OidcCommand(
            OidcGetOidcCustomSubTemplateForOrgCommand command0,
            OidcUpdateOidcCustomSubTemplateForOrgCommand command1)
            : base(
                name: "oidc")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
//HintName: G.Commands.DomainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DomainCommand : global::System.CommandLine.Command
    {
        public DomainCommand(
            GetDomainsCommand command0)
            : base(
                name: "domain")
        {
            Subcommands.Add(command0);
        }
    }
}
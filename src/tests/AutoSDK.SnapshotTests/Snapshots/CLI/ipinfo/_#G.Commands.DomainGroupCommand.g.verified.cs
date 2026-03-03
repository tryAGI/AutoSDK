//HintName: G.Commands.DomainGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DomainGroupCommand : global::System.CommandLine.Command
    {
        public DomainGroupCommand(
            GetDomainsCommand command0)
            : base(
                name: "domain")
        {
            Subcommands.Add(command0);
        }
    }
}
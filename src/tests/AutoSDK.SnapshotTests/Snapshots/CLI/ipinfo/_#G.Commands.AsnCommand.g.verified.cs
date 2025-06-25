//HintName: G.Commands.AsnCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AsnCommand : global::System.CommandLine.Command
    {
        public AsnCommand(
            GetAsnCommand command0)
            : base(
                name: "asn")
        {
            Subcommands.Add(command0);
        }
    }
}
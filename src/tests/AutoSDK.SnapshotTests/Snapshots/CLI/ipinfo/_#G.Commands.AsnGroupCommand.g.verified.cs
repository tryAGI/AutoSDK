//HintName: G.Commands.AsnGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AsnGroupCommand : global::System.CommandLine.Command
    {
        public AsnGroupCommand(
            GetAsnCommand command0)
            : base(
                name: "asn")
        {
            Subcommands.Add(command0);
        }
    }
}
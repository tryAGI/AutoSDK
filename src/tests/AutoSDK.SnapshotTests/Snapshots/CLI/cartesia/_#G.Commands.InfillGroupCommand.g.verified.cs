//HintName: G.Commands.InfillGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InfillGroupCommand : global::System.CommandLine.Command
    {
        public InfillGroupCommand(
            InfillInfillBytesCommand command0)
            : base(
                name: "infill")
        {
            Subcommands.Add(command0);
        }
    }
}
//HintName: G.Commands.ForcedAlignmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ForcedAlignmentCommand : global::System.CommandLine.Command
    {
        public ForcedAlignmentCommand(
            CreateForcedAlignmentCommand command0)
            : base(
                name: "forcedalignment")
        {
            Subcommands.Add(command0);
        }
    }
}
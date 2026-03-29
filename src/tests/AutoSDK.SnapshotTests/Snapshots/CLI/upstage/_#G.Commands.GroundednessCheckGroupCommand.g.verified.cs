//HintName: G.Commands.GroundednessCheckGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroundednessCheckGroupCommand : global::System.CommandLine.Command
    {
        public GroundednessCheckGroupCommand(
            GroundednessCheckGroundednessCheckCommand command0)
            : base(
                name: "groundednesscheck")
        {
            Subcommands.Add(command0);
        }
    }
}
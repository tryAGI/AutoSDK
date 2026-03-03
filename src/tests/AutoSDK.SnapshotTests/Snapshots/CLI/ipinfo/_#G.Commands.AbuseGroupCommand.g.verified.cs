//HintName: G.Commands.AbuseGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AbuseGroupCommand : global::System.CommandLine.Command
    {
        public AbuseGroupCommand(
            GetAbuseCommand command0)
            : base(
                name: "abuse")
        {
            Subcommands.Add(command0);
        }
    }
}
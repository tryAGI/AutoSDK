//HintName: G.Commands.AbuseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AbuseCommand : global::System.CommandLine.Command
    {
        public AbuseCommand(
            GetAbuseCommand command0)
            : base(
                name: "abuse")
        {
            Subcommands.Add(command0);
        }
    }
}
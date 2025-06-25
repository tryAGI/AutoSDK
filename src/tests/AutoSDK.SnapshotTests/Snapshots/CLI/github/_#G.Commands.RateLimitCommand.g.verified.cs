//HintName: G.Commands.RateLimitCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RateLimitCommand : global::System.CommandLine.Command
    {
        public RateLimitCommand(
            RateLimitGetCommand command0)
            : base(
                name: "ratelimit")
        {
            Subcommands.Add(command0);
        }
    }
}
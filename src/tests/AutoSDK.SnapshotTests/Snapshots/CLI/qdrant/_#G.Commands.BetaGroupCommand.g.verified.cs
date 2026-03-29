//HintName: G.Commands.BetaGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaGroupCommand : global::System.CommandLine.Command
    {
        public BetaGroupCommand(
            BetaClearIssuesCommand command0,
            BetaGetIssuesCommand command1)
            : base(
                name: "beta")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
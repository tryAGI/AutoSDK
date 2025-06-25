//HintName: G.Commands.AnalyticCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnalyticCommand : global::System.CommandLine.Command
    {
        public AnalyticCommand(
            GetExtensionAnalyticsCommand command0,
            GetGameAnalyticsCommand command1)
            : base(
                name: "analytic")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
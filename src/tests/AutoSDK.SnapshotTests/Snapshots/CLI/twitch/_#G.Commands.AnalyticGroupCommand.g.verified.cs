//HintName: G.Commands.AnalyticGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnalyticGroupCommand : global::System.CommandLine.Command
    {
        public AnalyticGroupCommand(
            AnalyticsGetExtensionAnalyticsCommand command0,
            AnalyticsGetGameAnalyticsCommand command1)
            : base(
                name: "analytic")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
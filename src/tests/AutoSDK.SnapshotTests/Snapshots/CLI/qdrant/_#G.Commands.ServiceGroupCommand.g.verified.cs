//HintName: G.Commands.ServiceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ServiceGroupCommand : global::System.CommandLine.Command
    {
        public ServiceGroupCommand(
            ServiceHealthzCommand command0,
            ServiceLivezCommand command1,
            ServiceMetricsCommand command2,
            ServiceReadyzCommand command3,
            ServiceRootCommand command4,
            ServiceTelemetryCommand command5)
            : base(
                name: "service")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}
//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AppGroupCommand command0,
            ArtifactGroupCommand command1,
            MetricGroupCommand command2,
            ModelGroupCommand command3,
            NamespaceGroupCommand command4,
            SubscriptionGroupCommand command5,
            VdpGroupCommand command6)
            : base(
                description: "CLI tool")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
        }
    }
}
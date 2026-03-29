//HintName: G.Commands.RedirectGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RedirectGroupCommand : global::System.CommandLine.Command
    {
        public RedirectGroupCommand(
            RedirectDatasetsRedirectCommand command0,
            RedirectExperimentsRedirectCommand command1,
            RedirectOptimizationsRedirectCommand command2,
            RedirectProjectsRedirectCommand command3)
            : base(
                name: "redirect")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}
//HintName: G.Commands.ResearchGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResearchGroupCommand : global::System.CommandLine.Command
    {
        public ResearchGroupCommand(
            ResearchGetDeepResearchStatusCommand command0,
            ResearchStartDeepResearchCommand command1)
            : base(
                name: "research")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}
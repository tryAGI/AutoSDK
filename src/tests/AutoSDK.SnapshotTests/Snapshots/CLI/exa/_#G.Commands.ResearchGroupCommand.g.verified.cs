//HintName: G.Commands.ResearchGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResearchGroupCommand : global::System.CommandLine.Command
    {
        public ResearchGroupCommand(
            ResearchResearchControllerCreateResearchCommand command0,
            ResearchResearchControllerGetResearchCommand command1,
            ResearchResearchControllerListResearchCommand command2)
            : base(
                name: "research")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}
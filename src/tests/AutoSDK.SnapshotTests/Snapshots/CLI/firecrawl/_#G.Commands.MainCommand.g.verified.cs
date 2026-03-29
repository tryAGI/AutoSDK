//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            BillingGroupCommand command0,
            CrawlingGroupCommand command1,
            ExtractionGroupCommand command2,
            LLMsTxtGroupCommand command3,
            MappingGroupCommand command4,
            ResearchGroupCommand command5,
            ScrapingGroupCommand command6,
            SearchGroupCommand command7)
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
            Subcommands.Add(command7);
        }
    }
}
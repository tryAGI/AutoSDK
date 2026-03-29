//HintName: G.Commands.ScrapingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ScrapingGroupCommand : global::System.CommandLine.Command
    {
        public ScrapingGroupCommand(
            ScrapingCancelBatchScrapeCommand command0,
            ScrapingGetBatchScrapeErrorsCommand command1,
            ScrapingGetBatchScrapeStatusCommand command2,
            ScrapingScrapeAndExtractFromUrlCommand command3,
            ScrapingScrapeAndExtractFromUrlsCommand command4)
            : base(
                name: "scraping")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}
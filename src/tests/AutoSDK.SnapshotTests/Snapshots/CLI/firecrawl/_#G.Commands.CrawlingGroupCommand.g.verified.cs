//HintName: G.Commands.CrawlingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CrawlingGroupCommand : global::System.CommandLine.Command
    {
        public CrawlingGroupCommand(
            CrawlingCancelCrawlCommand command0,
            CrawlingCrawlUrlsCommand command1,
            CrawlingGetActiveCrawlsCommand command2,
            CrawlingGetCrawlErrorsCommand command3,
            CrawlingGetCrawlStatusCommand command4)
            : base(
                name: "crawling")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}
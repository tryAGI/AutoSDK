//HintName: G.Commands.CorporaSourcesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaSourcesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid corpusId,
            string? requestCorpusId,
            string? sourceId,
            global::System.DateTime? created,
            string? name,
            string? description,
            global::G.UltravoxV1SourceStats? stats,
            global::G.UltravoxV1CrawlSpec? loadSpec,
            global::G.UltravoxV1CrawlSpec? crawl,
            global::G.UltravoxV1UploadSpec? upload,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UltravoxV1CorpusSource response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CorpusId { get; } = new(
            name: "corpusId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> RequestCorpusId { get; } = new(
            name: "requestCorpusId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> SourceId { get; } = new(
            name: "sourceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Created { get; } = new(
            name: "created")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1SourceStats?> Stats { get; } = new(
            name: "stats")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CrawlSpec?> LoadSpec { get; } = new(
            name: "loadSpec")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CrawlSpec?> Crawl { get; } = new(
            name: "crawl")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1UploadSpec?> Upload { get; } = new(
            name: "upload")
        {
            Description = @"",
        };
        public CorporaSourcesCreateCommand(G.IApi client) : base(
            name: "corpora",
            description: @"")
        {
            _client = client;

            Arguments.Add(CorpusId);
            Options.Add(RequestCorpusId);
            Options.Add(SourceId);
            Options.Add(Created);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Stats);
            Options.Add(LoadSpec);
            Options.Add(Crawl);
            Options.Add(Upload);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var corpusId = parseResult.GetRequiredValue(CorpusId);
            var requestCorpusId = parseResult.GetRequiredValue(RequestCorpusId);
            var sourceId = parseResult.GetRequiredValue(SourceId);
            var created = parseResult.GetRequiredValue(Created);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var stats = parseResult.GetRequiredValue(Stats);
            var loadSpec = parseResult.GetRequiredValue(LoadSpec);
            var crawl = parseResult.GetRequiredValue(Crawl);
            var upload = parseResult.GetRequiredValue(Upload);

            Validate(
                parseResult: parseResult,
                corpusId: corpusId,
                requestCorpusId: requestCorpusId,
                sourceId: sourceId,
                created: created,
                name: name,
                description: description,
                stats: stats,
                loadSpec: loadSpec,
                crawl: crawl,
                upload: upload,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Corpora.CorporaSourcesCreateAsync(
                corpusId: corpusId,
                requestCorpusId: requestCorpusId,
                sourceId: sourceId,
                created: created,
                name: name,
                description: description,
                stats: stats,
                loadSpec: loadSpec,
                crawl: crawl,
                upload: upload,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
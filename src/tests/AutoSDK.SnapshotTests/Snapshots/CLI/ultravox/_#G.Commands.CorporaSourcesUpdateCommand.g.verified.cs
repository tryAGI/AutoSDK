//HintName: G.Commands.CorporaSourcesUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaSourcesUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid corpusId,
            global::System.Guid sourceId,
            string? requestCorpusId,
            string? requestSourceId,
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

        private global::System.CommandLine.Argument<global::System.Guid> SourceId { get; } = new(
            name: "sourceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> RequestCorpusId { get; } = new(
            name: "requestCorpusId")
        {
            Description = @"The id of this source's corpus.",
        };

        private global::System.CommandLine.Option<string?> RequestSourceId { get; } = new(
            name: "requestSourceId")
        {
            Description = @"The unique ID of this source.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Created { get; } = new(
            name: "created")
        {
            Description = @"When this source was created.",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of this source.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"A description of this source.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1SourceStats?> Stats { get; } = new(
            name: "stats")
        {
            Description = @"The current stats for this source.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CrawlSpec?> LoadSpec { get; } = new(
            name: "loadSpec")
        {
            Description = @"DEPRECATED. Prefer setting crawl instead. If either crawl or upload is set, this field will be ignored.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CrawlSpec?> Crawl { get; } = new(
            name: "crawl")
        {
            Description = @"Allows loading documents by crawling the web.",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1UploadSpec?> Upload { get; } = new(
            name: "upload")
        {
            Description = @"Allows loading from a uploaded document.",
        };
        public CorporaSourcesUpdateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "corpora",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CorpusId);
            Arguments.Add(SourceId);
            Options.Add(RequestCorpusId);
            Options.Add(RequestSourceId);
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
            var sourceId = parseResult.GetRequiredValue(SourceId);
            var requestCorpusId = parseResult.GetRequiredValue(RequestCorpusId);
            var requestSourceId = parseResult.GetRequiredValue(RequestSourceId);
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
                sourceId: sourceId,
                requestCorpusId: requestCorpusId,
                requestSourceId: requestSourceId,
                created: created,
                name: name,
                description: description,
                stats: stats,
                loadSpec: loadSpec,
                crawl: crawl,
                upload: upload,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Corpora.CorporaSourcesUpdateAsync(
                corpusId: corpusId,
                sourceId: sourceId,
                requestCorpusId: requestCorpusId,
                requestSourceId: requestSourceId,
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
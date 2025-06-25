//HintName: G.Commands.CorporaCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? corpusId,
            global::System.DateTime? created,
            string? name,
            string? description,
            global::G.UltravoxV1CorpusStats? stats,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UltravoxV1Corpus response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> CorpusId { get; } = new(
            name: "corpusId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Created { get; } = new(
            name: "created")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UltravoxV1CorpusStats?> Stats { get; } = new(
            name: "stats")
        {
            Description = "",
        };
        public CorporaCreateCommand(G.IApi client) : base(
            name: "corpora",
            description: @"")
        {
            _client = client;

            Options.Add(CorpusId);
            Options.Add(Created);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Stats);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var corpusId = parseResult.GetRequiredValue(CorpusId);
            var created = parseResult.GetRequiredValue(Created);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var stats = parseResult.GetRequiredValue(Stats);

            Validate(
                parseResult: parseResult,
                corpusId: corpusId,
                created: created,
                name: name,
                description: description,
                stats: stats,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Corpora.CorporaCreateAsync(
                corpusId: corpusId,
                created: created,
                name: name,
                description: description,
                stats: stats,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
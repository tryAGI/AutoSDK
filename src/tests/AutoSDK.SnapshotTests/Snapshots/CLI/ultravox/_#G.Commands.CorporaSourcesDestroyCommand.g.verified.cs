//HintName: G.Commands.CorporaSourcesDestroyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaSourcesDestroyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid corpusId,
            global::System.Guid sourceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        public CorporaSourcesDestroyCommand(G.IApi client) : base(
            name: "corpora",
            description: @"")
        {
            _client = client;

            Arguments.Add(CorpusId);
            Arguments.Add(SourceId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var corpusId = parseResult.GetRequiredValue(CorpusId);
            var sourceId = parseResult.GetRequiredValue(SourceId);

            Validate(
                parseResult: parseResult,
                corpusId: corpusId,
                sourceId: sourceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Corpora.CorporaSourcesDestroyAsync(
                corpusId: corpusId,
                sourceId: sourceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
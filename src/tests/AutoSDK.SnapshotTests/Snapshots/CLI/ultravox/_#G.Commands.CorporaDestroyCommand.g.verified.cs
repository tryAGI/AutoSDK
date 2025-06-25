//HintName: G.Commands.CorporaDestroyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaDestroyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid corpusId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CorpusId { get; } = new(
            name: "corpusId")
        {
            Description = @"",
        };

        public CorporaDestroyCommand(G.IApi client) : base(
            name: "corpora",
            description: @"")
        {
            _client = client;

            Arguments.Add(CorpusId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var corpusId = parseResult.GetRequiredValue(CorpusId);

            Validate(
                parseResult: parseResult,
                corpusId: corpusId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Corpora.CorporaDestroyAsync(
                corpusId: corpusId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.BatchReferencesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchReferencesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BatchReferencesCreateConsistencyLevel? consistencyLevel,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.BatchReferenceResponse> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.BatchReferencesCreateConsistencyLevel?> ConsistencyLevel { get; } = new(
            name: "consistencyLevel")
        {
            Description = "",
        };
        public BatchReferencesCreateCommand(G.IApi client) : base(
            name: "batch",
            description: @"Batch create cross-references between collections items (objects or objects) in bulk.")
        {
            _client = client;

            Options.Add(ConsistencyLevel);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var consistencyLevel = parseResult.GetRequiredValue(ConsistencyLevel);

            Validate(
                parseResult: parseResult,
                consistencyLevel: consistencyLevel,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Batch.BatchReferencesCreateAsync(
                consistencyLevel: consistencyLevel,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
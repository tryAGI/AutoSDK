//HintName: G.Commands.UpdateChunkCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChunkCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string chunkUid,
            bool? retrievable,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateChunkResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ChunkUid { get; } = new(
            name: "chunkUid")
        {
            Description = @"chunk uid",
        };

        private global::System.CommandLine.Option<bool?> Retrievable { get; } = new(
            name: "retrievable")
        {
            Description = @"",
        };
        public UpdateChunkCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Updates a catalog chunk.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ChunkUid);
            Options.Add(Retrievable);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var chunkUid = parseResult.GetRequiredValue(ChunkUid);
            var retrievable = parseResult.GetRequiredValue(Retrievable);

            Validate(
                parseResult: parseResult,
                chunkUid: chunkUid,
                retrievable: retrievable,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.UpdateChunkAsync(
                chunkUid: chunkUid,
                retrievable: retrievable,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
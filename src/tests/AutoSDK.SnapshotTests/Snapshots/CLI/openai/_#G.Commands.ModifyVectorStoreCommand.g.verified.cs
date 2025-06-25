//HintName: G.Commands.ModifyVectorStoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModifyVectorStoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string vectorStoreId,
            string? name,
            global::G.AllOf<global::G.VectorStoreExpirationAfter, object>? expiresAfter,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VectorStoreObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VectorStoreId { get; } = new(
            name: "vectorStoreId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AllOf<global::G.VectorStoreExpirationAfter, object>?> ExpiresAfter { get; } = new(
            name: "expiresAfter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };
        public ModifyVectorStoreCommand(G.IOpenAiClient client) : base(
            name: "modify",
            description: @"")
        {
            _client = client;

            Arguments.Add(VectorStoreId);
            Options.Add(Name);
            Options.Add(ExpiresAfter);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
            var name = parseResult.GetRequiredValue(Name);
            var expiresAfter = parseResult.GetRequiredValue(ExpiresAfter);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                vectorStoreId: vectorStoreId,
                name: name,
                expiresAfter: expiresAfter,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorStores.ModifyVectorStoreAsync(
                vectorStoreId: vectorStoreId,
                name: name,
                expiresAfter: expiresAfter,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
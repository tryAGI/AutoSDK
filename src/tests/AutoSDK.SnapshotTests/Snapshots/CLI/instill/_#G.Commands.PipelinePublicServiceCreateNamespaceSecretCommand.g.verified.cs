//HintName: G.Commands.PipelinePublicServiceCreateNamespaceSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceCreateNamespaceSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string? id,
            string? value,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateNamespaceSecretResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Value { get; } = new(
            name: "value")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };
        public PipelinePublicServiceCreateNamespaceSecretCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Creates a new secret under the parenthood of an namespace.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Options.Add(Id);
            Options.Add(Value);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var id = parseResult.GetRequiredValue(Id);
            var value = parseResult.GetRequiredValue(Value);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                id: id,
                value: value,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceCreateNamespaceSecretAsync(
                namespaceId: namespaceId,
                id: id,
                value: value,
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.PipelinePublicServiceUpdateNamespaceSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceUpdateNamespaceSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string secretId,
            string? id,
            string? value,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateNamespaceSecretResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> SecretId { get; } = new(
            name: "secretId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Value { get; } = new(
            name: "value")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };
        public PipelinePublicServiceUpdateNamespaceSecretCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Udpates a secret, accessing it by its resource name, which is defined by

In REST requests, only the supplied secret fields will be taken into
account when updating the resource.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(SecretId);
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
            var secretId = parseResult.GetRequiredValue(SecretId);
            var id = parseResult.GetRequiredValue(Id);
            var value = parseResult.GetRequiredValue(Value);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                secretId: secretId,
                id: id,
                value: value,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceUpdateNamespaceSecretAsync(
                namespaceId: namespaceId,
                secretId: secretId,
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
﻿//HintName: G.Commands.PipelinePublicServiceCreateNamespaceSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceCreateNamespaceSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"Secret resource ID (used in `name` as the last segment). This conforms
to RFC-1034, which restricts to letters, numbers, and hyphen, with the
first character a letter, the last a letter or a number, and a 63
character maximum.",
        };

        private global::System.CommandLine.Option<string?> Value { get; } = new(
            name: "value")
        {
            Description = @"The value of the secret, which is input-only and will never be returned in API responses.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };
        public PipelinePublicServiceCreateNamespaceSecretCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Creates a new secret under the parenthood of an namespace.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
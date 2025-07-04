﻿//HintName: G.Commands.CreateCatalogCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateCatalogCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateCatalogResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"The catalog's owner(namespaces).",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The catalog name.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"The catalog description.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"The catalog tags.",
        };
        public CreateCatalogCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a catalog.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Tags);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var tags = parseResult.GetRequiredValue(Tags);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                name: name,
                description: description,
                tags: tags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.CreateCatalogAsync(
                namespaceId: namespaceId,
                name: name,
                description: description,
                tags: tags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
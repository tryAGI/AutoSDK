﻿//HintName: G.Commands.SimilarityChunksSearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SimilarityChunksSearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string catalogId,
            string? instillRequesterUid,
            string? textPrompt,
            long? topK,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SimilarityChunksSearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"owner/namespace id",
        };

        private global::System.CommandLine.Argument<string> CatalogId { get; } = new(
            name: "catalogId")
        {
            Description = @"catalog id",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"Indicates the authenticated namespace is making the request on behalf of another entity, typically an organization they belong to",
        };

        private global::System.CommandLine.Option<string?> TextPrompt { get; } = new(
            name: "textPrompt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<long?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"",
        };
        public SimilarityChunksSearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "similarity",
            description: @"Returns the similar chunks.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(CatalogId);
            Options.Add(InstillRequesterUid);
            Options.Add(TextPrompt);
            Options.Add(TopK);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var catalogId = parseResult.GetRequiredValue(CatalogId);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);
            var textPrompt = parseResult.GetRequiredValue(TextPrompt);
            var topK = parseResult.GetRequiredValue(TopK);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                catalogId: catalogId,
                instillRequesterUid: instillRequesterUid,
                textPrompt: textPrompt,
                topK: topK,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.SimilarityChunksSearchAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                instillRequesterUid: instillRequesterUid,
                textPrompt: textPrompt,
                topK: topK,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
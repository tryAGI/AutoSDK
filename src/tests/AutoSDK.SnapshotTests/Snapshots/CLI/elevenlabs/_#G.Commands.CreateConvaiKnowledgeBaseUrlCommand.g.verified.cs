﻿//HintName: G.Commands.CreateConvaiKnowledgeBaseUrlCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiKnowledgeBaseUrlCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string url,
            string? name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddKnowledgeBaseResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };
        public CreateConvaiKnowledgeBaseUrlCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a knowledge base document generated by scraping the given webpage.")
        {
            _client = client;

            Arguments.Add(Url);
            Options.Add(XiApiKey);
            Options.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var url = parseResult.GetRequiredValue(Url);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                url: url,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiKnowledgeBaseUrlAsync(
                xiApiKey: xiApiKey,
                url: url,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
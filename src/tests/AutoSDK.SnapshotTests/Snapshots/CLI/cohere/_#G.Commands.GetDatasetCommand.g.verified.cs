﻿//HintName: G.Commands.GetDatasetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetDatasetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string id,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetDatasetResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };
        public GetDatasetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve a dataset by ID. See ['Datasets'](https://docs.cohere.com/docs/datasets) for more information.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var xClientName = parseResult.GetRequiredValue(XClientName);

            Validate(
                parseResult: parseResult,
                id: id,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.GetDatasetAsync(
                id: id,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
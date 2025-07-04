﻿//HintName: G.Commands.ListConnectorsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListConnectorsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            double? limit,
            double? offset,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListConnectorsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<double?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Maximum number of connectors to return [0, 100].",
        };

        private global::System.CommandLine.Option<double?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"Number of connectors to skip before returning results [0, inf].",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };
        public ListConnectorsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Returns a list of connectors ordered by descending creation date (newer first). See ['Managing your Connector'](https://docs.cohere.com/docs/managing-your-connector) for more information.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Limit);
            Options.Add(Offset);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var limit = parseResult.GetRequiredValue(Limit);
            var offset = parseResult.GetRequiredValue(Offset);
            var xClientName = parseResult.GetRequiredValue(XClientName);

            Validate(
                parseResult: parseResult,
                limit: limit,
                offset: offset,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Connectors.ListConnectorsAsync(
                limit: limit,
                offset: offset,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
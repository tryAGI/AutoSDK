﻿//HintName: G.Commands.ListTunedModelOperationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListTunedModelOperationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tunedModelId,
            int? pageSize,
            string? filter,
            string? pageToken,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListOperationsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TunedModelId { get; } = new(
            name: "tunedModelId")
        {
            Description = @"The id of the tuned model.",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The standard list page size.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"The filters to apply.",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"The token identifying which page to start with.",
        };
        public ListTunedModelOperationsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Lists operations that match the specified filter in the request. If the server doesn't support this method, it returns `UNIMPLEMENTED`.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TunedModelId);
            Options.Add(PageSize);
            Options.Add(Filter);
            Options.Add(PageToken);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tunedModelId = parseResult.GetRequiredValue(TunedModelId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var filter = parseResult.GetRequiredValue(Filter);
            var pageToken = parseResult.GetRequiredValue(PageToken);

            Validate(
                parseResult: parseResult,
                tunedModelId: tunedModelId,
                pageSize: pageSize,
                filter: filter,
                pageToken: pageToken,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ListTunedModelOperationsAsync(
                tunedModelId: tunedModelId,
                pageSize: pageSize,
                filter: filter,
                pageToken: pageToken,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
﻿//HintName: G.Commands.CallsMessagesListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallsMessagesListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid callId,
            string? cursor,
            int? pageSize,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PaginatedultravoxV1MessageList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CallId { get; } = new(
            name: "callId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = @"The pagination cursor value.",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"Number of results to return per page.",
        };
        public CallsMessagesListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "calls",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CallId);
            Options.Add(Cursor);
            Options.Add(PageSize);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var callId = parseResult.GetRequiredValue(CallId);
            var cursor = parseResult.GetRequiredValue(Cursor);
            var pageSize = parseResult.GetRequiredValue(PageSize);

            Validate(
                parseResult: parseResult,
                callId: callId,
                cursor: cursor,
                pageSize: pageSize,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Calls.CallsMessagesListAsync(
                callId: callId,
                cursor: cursor,
                pageSize: pageSize,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
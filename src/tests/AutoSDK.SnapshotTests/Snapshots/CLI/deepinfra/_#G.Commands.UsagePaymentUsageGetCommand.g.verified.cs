﻿//HintName: G.Commands.UsagePaymentUsageGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsagePaymentUsageGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string from,
            string? to,
            string? session,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UsageOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> From { get; } = new(
            name: "from")
        {
            Description = @"start of period, YYYY.MM or current(-N) format",
        };

        private global::System.CommandLine.Option<string?> To { get; } = new(
            name: "to")
        {
            Description = @"end of period (if missing a single month marked by from is return), same format as from",
        };

        private global::System.CommandLine.Option<string?> Session { get; } = new(
            name: "session")
        {
            Description = @"",
        };
        public UsagePaymentUsageGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "usage",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(From);
            Options.Add(To);
            Options.Add(Session);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var from = parseResult.GetRequiredValue(From);
            var to = parseResult.GetRequiredValue(To);
            var session = parseResult.GetRequiredValue(Session);

            Validate(
                parseResult: parseResult,
                from: from,
                to: to,
                session: session,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.UsagePaymentUsageGetAsync(
                from: from,
                to: to,
                session: session,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
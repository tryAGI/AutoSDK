﻿//HintName: G.Commands.GetConfigPaymentConfigGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConfigPaymentConfigGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? session,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ConfigOut response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Session { get; } = new(
            name: "session")
        {
            Description = "",
        };
        public GetConfigPaymentConfigGetCommand(G.IApi client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Options.Add(Session);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var session = parseResult.GetRequiredValue(Session);

            Validate(
                parseResult: parseResult,
                session: session,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GetConfigPaymentConfigGetAsync(
                session: session,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
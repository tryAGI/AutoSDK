﻿//HintName: G.Commands.CreateTemporaryTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTemporaryTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int expiresIn,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RealtimeTemporaryTokenResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ExpiresIn { get; } = new(
            name: "expiresIn")
        {
            Description = @"The amount of time until the token expires in seconds",
        };

        public CreateTemporaryTokenCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a temporary authentication token for Streaming Speech-to-Text")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ExpiresIn);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var expiresIn = parseResult.GetRequiredValue(ExpiresIn);

            Validate(
                parseResult: parseResult,
                expiresIn: expiresIn,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Streaming.CreateTemporaryTokenAsync(
                expiresIn: expiresIn,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
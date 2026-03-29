//HintName: G.Commands.VoiceAPIRequestReconnectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceAPIRequestReconnectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string token,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VoiceStreamingResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Token { get; } = new(
            name: "token")
        {
            Description = @"The latest ephemeral token obtained for the stream.",
        };



        public VoiceAPIRequestReconnectionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "request",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Token);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var token = parseResult.GetRequiredValue(Token);

            Validate(
                parseResult: parseResult,
                token: token,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VoiceAPI.RequestReconnectionAsync(
                token: token,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
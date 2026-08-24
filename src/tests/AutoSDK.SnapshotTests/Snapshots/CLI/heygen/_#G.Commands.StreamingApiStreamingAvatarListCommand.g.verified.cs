//HintName: G.Commands.StreamingApiStreamingAvatarListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingApiStreamingAvatarListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,

            string request,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);




        private global::System.CommandLine.Argument<string> RequestBody { get; } = new(
            name: "request-body")
        {
            Description = @"The request body as JSON.",
        };


        public StreamingApiStreamingAvatarListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "streaming",
            description: @"streaming/avatar.list")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Arguments.Add(RequestBody);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __requestBodyJson = parseResult.GetRequiredValue(RequestBody);
            var request = global::System.Text.Json.JsonSerializer.Deserialize<string>(__requestBodyJson) ??
                throw new global::System.InvalidOperationException("Failed to deserialize request body.");

            Validate(
                parseResult: parseResult,

                request: request,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.StreamingApi.StreamingAvatarListAsync(

                request: request,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.StreamingNewCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingNewCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? quality,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Quality { get; } = new(
            name: "quality")
        {
            Description = @"",
        };
        public StreamingNewCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "streaming",
            description: @"streaming.new")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Quality);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var quality = parseResult.GetRequiredValue(Quality);

            Validate(
                parseResult: parseResult,
                quality: quality,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.StreamingAPI.StreamingNewAsync(
                quality: quality,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
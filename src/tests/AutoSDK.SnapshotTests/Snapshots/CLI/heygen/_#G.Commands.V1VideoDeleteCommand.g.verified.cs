//HintName: G.Commands.V1VideoDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class V1VideoDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? videoId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> VideoId { get; } = new(
            name: "videoId")
        {
            Description = @"",
        };
        public V1VideoDeleteCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "v1video",
            description: @"v1/video.delete")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(VideoId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var videoId = parseResult.GetRequiredValue(VideoId);

            Validate(
                parseResult: parseResult,
                videoId: videoId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CreateVideoAPI.V1VideoDeleteAsync(
                videoId: videoId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
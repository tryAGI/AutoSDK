//HintName: G.Commands.PostGenerateImageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PostGenerateImageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ImageRequest imageRequest,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GenerateImageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.ImageRequest> ImageRequest { get; } = new(
            name: "imageRequest")
        {
            Description = @"",
        };

        public PostGenerateImageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "post",
            description: @"A request to generate an image with Ideogram.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ImageRequest);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var imageRequest = parseResult.GetRequiredValue(ImageRequest);

            Validate(
                parseResult: parseResult,
                imageRequest: imageRequest,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Generate.PostGenerateImageAsync(
                imageRequest: imageRequest,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
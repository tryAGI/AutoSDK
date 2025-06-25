//HintName: G.Commands.GenerativeUpscaleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerativeUpscaleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] image,
            string imagename,
            global::G.ResponseFormat? responseFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProcessImageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> Image { get; } = new(
            name: "image")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Imagename { get; } = new(
            name: "imagename")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };
        public GenerativeUpscaleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generative",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Image);
            Arguments.Add(Imagename);
            Options.Add(ResponseFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var image = parseResult.GetRequiredValue(Image);
            var imagename = parseResult.GetRequiredValue(Imagename);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);

            Validate(
                parseResult: parseResult,
                image: image,
                imagename: imagename,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Image.GenerativeUpscaleAsync(
                image: image,
                imagename: imagename,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
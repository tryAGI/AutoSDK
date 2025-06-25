//HintName: G.Commands.CreateImageVariationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateImageVariationCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] image,
            string imagename,
            global::G.AnyOf<string, global::G.CreateImageVariationRequestModel?>? model,
            int? n,
            global::G.CreateImageVariationRequestResponseFormat? responseFormat,
            global::G.CreateImageVariationRequestSize? size,
            string? user,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ImagesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> Image { get; } = new(
            name: "image")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Imagename { get; } = new(
            name: "imagename")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::G.CreateImageVariationRequestModel?>?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageVariationRequestResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageVariationRequestSize?> Size { get; } = new(
            name: "size")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = "",
        };
        public CreateImageVariationCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Image);
            Arguments.Add(Imagename);
            Options.Add(Model);
            Options.Add(N);
            Options.Add(ResponseFormat);
            Options.Add(Size);
            Options.Add(User);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var image = parseResult.GetRequiredValue(Image);
            var imagename = parseResult.GetRequiredValue(Imagename);
            var model = parseResult.GetRequiredValue(Model);
            var n = parseResult.GetRequiredValue(N);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var size = parseResult.GetRequiredValue(Size);
            var user = parseResult.GetRequiredValue(User);

            Validate(
                parseResult: parseResult,
                image: image,
                imagename: imagename,
                model: model,
                n: n,
                responseFormat: responseFormat,
                size: size,
                user: user,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Images.CreateImageVariationAsync(
                image: image,
                imagename: imagename,
                model: model,
                n: n,
                responseFormat: responseFormat,
                size: size,
                user: user,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
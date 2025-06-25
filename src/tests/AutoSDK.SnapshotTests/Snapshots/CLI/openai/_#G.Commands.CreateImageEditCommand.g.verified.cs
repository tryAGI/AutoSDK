//HintName: G.Commands.CreateImageEditCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateImageEditCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>> image,
            string prompt,
            byte[]? mask,
            string? maskname,
            global::G.CreateImageEditRequestBackground? background,
            global::G.AnyOf<string, global::G.CreateImageEditRequestModel?>? model,
            int? n,
            global::G.CreateImageEditRequestSize? size,
            global::G.CreateImageEditRequestResponseFormat? responseFormat,
            global::G.CreateImageEditRequestOutputFormat? outputFormat,
            int? outputCompression,
            string? user,
            global::G.CreateImageEditRequestQuality? quality,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ImagesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>>> Image { get; } = new(
            name: "image")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> Mask { get; } = new(
            name: "mask")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Maskname { get; } = new(
            name: "maskname")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageEditRequestBackground?> Background { get; } = new(
            name: "background")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::G.CreateImageEditRequestModel?>?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageEditRequestSize?> Size { get; } = new(
            name: "size")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageEditRequestResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageEditRequestOutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> OutputCompression { get; } = new(
            name: "outputCompression")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageEditRequestQuality?> Quality { get; } = new(
            name: "quality")
        {
            Description = "",
        };
        public CreateImageEditCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Image);
            Arguments.Add(Prompt);
            Options.Add(Mask);
            Options.Add(Maskname);
            Options.Add(Background);
            Options.Add(Model);
            Options.Add(N);
            Options.Add(Size);
            Options.Add(ResponseFormat);
            Options.Add(OutputFormat);
            Options.Add(OutputCompression);
            Options.Add(User);
            Options.Add(Quality);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var image = parseResult.GetRequiredValue(Image);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var mask = parseResult.GetRequiredValue(Mask);
            var maskname = parseResult.GetRequiredValue(Maskname);
            var background = parseResult.GetRequiredValue(Background);
            var model = parseResult.GetRequiredValue(Model);
            var n = parseResult.GetRequiredValue(N);
            var size = parseResult.GetRequiredValue(Size);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var outputCompression = parseResult.GetRequiredValue(OutputCompression);
            var user = parseResult.GetRequiredValue(User);
            var quality = parseResult.GetRequiredValue(Quality);

            Validate(
                parseResult: parseResult,
                image: image,
                prompt: prompt,
                mask: mask,
                maskname: maskname,
                background: background,
                model: model,
                n: n,
                size: size,
                responseFormat: responseFormat,
                outputFormat: outputFormat,
                outputCompression: outputCompression,
                user: user,
                quality: quality,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Images.CreateImageEditAsync(
                image: image,
                prompt: prompt,
                mask: mask,
                maskname: maskname,
                background: background,
                model: model,
                n: n,
                size: size,
                responseFormat: responseFormat,
                outputFormat: outputFormat,
                outputCompression: outputCompression,
                user: user,
                quality: quality,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
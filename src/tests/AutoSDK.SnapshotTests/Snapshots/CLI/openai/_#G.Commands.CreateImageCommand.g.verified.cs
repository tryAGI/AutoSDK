//HintName: G.Commands.CreateImageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateImageCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string prompt,
            global::G.AnyOf<string, global::G.CreateImageRequestModel?>? model,
            int? n,
            global::G.CreateImageRequestQuality? quality,
            global::G.CreateImageRequestResponseFormat? responseFormat,
            global::G.CreateImageRequestOutputFormat? outputFormat,
            int? outputCompression,
            global::G.CreateImageRequestSize? size,
            global::G.CreateImageRequestModeration? moderation,
            global::G.CreateImageRequestBackground? background,
            global::G.CreateImageRequestStyle? style,
            string? user,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ImagesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::G.CreateImageRequestModel?>?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageRequestQuality?> Quality { get; } = new(
            name: "quality")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageRequestResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageRequestOutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> OutputCompression { get; } = new(
            name: "outputCompression")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageRequestSize?> Size { get; } = new(
            name: "size")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageRequestModeration?> Moderation { get; } = new(
            name: "moderation")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageRequestBackground?> Background { get; } = new(
            name: "background")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateImageRequestStyle?> Style { get; } = new(
            name: "style")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = "",
        };
        public CreateImageCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Prompt);
            Options.Add(Model);
            Options.Add(N);
            Options.Add(Quality);
            Options.Add(ResponseFormat);
            Options.Add(OutputFormat);
            Options.Add(OutputCompression);
            Options.Add(Size);
            Options.Add(Moderation);
            Options.Add(Background);
            Options.Add(Style);
            Options.Add(User);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var prompt = parseResult.GetRequiredValue(Prompt);
            var model = parseResult.GetRequiredValue(Model);
            var n = parseResult.GetRequiredValue(N);
            var quality = parseResult.GetRequiredValue(Quality);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var outputCompression = parseResult.GetRequiredValue(OutputCompression);
            var size = parseResult.GetRequiredValue(Size);
            var moderation = parseResult.GetRequiredValue(Moderation);
            var background = parseResult.GetRequiredValue(Background);
            var style = parseResult.GetRequiredValue(Style);
            var user = parseResult.GetRequiredValue(User);

            Validate(
                parseResult: parseResult,
                prompt: prompt,
                model: model,
                n: n,
                quality: quality,
                responseFormat: responseFormat,
                outputFormat: outputFormat,
                outputCompression: outputCompression,
                size: size,
                moderation: moderation,
                background: background,
                style: style,
                user: user,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Images.CreateImageAsync(
                prompt: prompt,
                model: model,
                n: n,
                quality: quality,
                responseFormat: responseFormat,
                outputFormat: outputFormat,
                outputCompression: outputCompression,
                size: size,
                moderation: moderation,
                background: background,
                style: style,
                user: user,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
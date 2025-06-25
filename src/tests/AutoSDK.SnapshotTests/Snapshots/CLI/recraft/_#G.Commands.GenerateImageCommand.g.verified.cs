//HintName: G.Commands.GenerateImageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateImageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UserControls? controls,
            global::G.TransformModel? model,
            int? n,
            string prompt,
            int? randomSeed,
            global::G.ResponseFormat? responseFormat,
            global::G.ImageSize? size,
            global::G.ImageStyle? style,
            global::System.Guid? styleId,
            global::G.ImageSubStyle? substyle,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GenerateImageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.UserControls?> Controls { get; } = new(
            name: "controls")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.TransformModel?> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> RandomSeed { get; } = new(
            name: "randomSeed")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ImageSize?> Size { get; } = new(
            name: "size")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ImageStyle?> Style { get; } = new(
            name: "style")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> StyleId { get; } = new(
            name: "styleId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ImageSubStyle?> Substyle { get; } = new(
            name: "substyle")
        {
            Description = @"",
        };
        public GenerateImageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Prompt);
            Options.Add(Controls);
            Options.Add(Model);
            Options.Add(N);
            Options.Add(RandomSeed);
            Options.Add(ResponseFormat);
            Options.Add(Size);
            Options.Add(Style);
            Options.Add(StyleId);
            Options.Add(Substyle);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var controls = parseResult.GetRequiredValue(Controls);
            var model = parseResult.GetRequiredValue(Model);
            var n = parseResult.GetRequiredValue(N);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var randomSeed = parseResult.GetRequiredValue(RandomSeed);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var size = parseResult.GetRequiredValue(Size);
            var style = parseResult.GetRequiredValue(Style);
            var styleId = parseResult.GetRequiredValue(StyleId);
            var substyle = parseResult.GetRequiredValue(Substyle);

            Validate(
                parseResult: parseResult,
                controls: controls,
                model: model,
                n: n,
                prompt: prompt,
                randomSeed: randomSeed,
                responseFormat: responseFormat,
                size: size,
                style: style,
                styleId: styleId,
                substyle: substyle,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Image.GenerateImageAsync(
                controls: controls,
                model: model,
                n: n,
                prompt: prompt,
                randomSeed: randomSeed,
                responseFormat: responseFormat,
                size: size,
                style: style,
                styleId: styleId,
                substyle: substyle,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
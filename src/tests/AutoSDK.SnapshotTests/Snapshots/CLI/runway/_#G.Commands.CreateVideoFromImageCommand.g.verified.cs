//HintName: G.Commands.CreateVideoFromImageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVideoFromImageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            string promptImage,
            global::G.CreateVideoFromImageRequestModel model,
            int? seed,
            string? promptText,
            bool? watermark,
            int? duration,
            global::G.CreateVideoFromImageRequestRatio? ratio,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateVideoFromImageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.CreateVideoFromImageXRunwayVersion> XRunwayVersion { get; } = new(
            name: "xRunwayVersion")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PromptImage { get; } = new(
            name: "promptImage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateVideoFromImageRequestModel> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> PromptText { get; } = new(
            name: "promptText")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Watermark { get; } = new(
            name: "watermark")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Duration { get; } = new(
            name: "duration")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateVideoFromImageRequestRatio?> Ratio { get; } = new(
            name: "ratio")
        {
            Description = "",
        };
        public CreateVideoFromImageCommand(G.IApi client) : base(
            name: "create",
            description: @"Start a new task to generate a video from an image prompt.")
        {
            _client = client;

            Arguments.Add(XRunwayVersion);
            Arguments.Add(PromptImage);
            Options.Add(Model);
            Options.Add(Seed);
            Options.Add(PromptText);
            Options.Add(Watermark);
            Options.Add(Duration);
            Options.Add(Ratio);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
            var promptImage = parseResult.GetRequiredValue(PromptImage);
            var model = parseResult.GetRequiredValue(Model);
            var seed = parseResult.GetRequiredValue(Seed);
            var promptText = parseResult.GetRequiredValue(PromptText);
            var watermark = parseResult.GetRequiredValue(Watermark);
            var duration = parseResult.GetRequiredValue(Duration);
            var ratio = parseResult.GetRequiredValue(Ratio);

            Validate(
                parseResult: parseResult,
                xRunwayVersion: xRunwayVersion,
                promptImage: promptImage,
                model: model,
                seed: seed,
                promptText: promptText,
                watermark: watermark,
                duration: duration,
                ratio: ratio,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateVideoFromImageAsync(
                xRunwayVersion: xRunwayVersion,
                promptImage: promptImage,
                model: model,
                seed: seed,
                promptText: promptText,
                watermark: watermark,
                duration: duration,
                ratio: ratio,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
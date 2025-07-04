﻿//HintName: G.Commands.CreateVideoFromImageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVideoFromImageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"API version header.",
        };

        private global::System.CommandLine.Argument<string> PromptImage { get; } = new(
            name: "promptImage")
        {
            Description = @"HTTPS URL of an image (JPEG, PNG, WebP, max 16MB).",
        };

        private global::System.CommandLine.Option<global::G.CreateVideoFromImageRequestModel> Model { get; } = new(
            name: "model")
        {
            Description = @"The model variant to use.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Seed value for generating consistent results.",
        };

        private global::System.CommandLine.Option<string?> PromptText { get; } = new(
            name: "promptText")
        {
            Description = @"A detailed description of the output.",
        };

        private global::System.CommandLine.Option<bool?> Watermark { get; } = new(
            name: "watermark")
        {
            Description = @"Add a Runway watermark to the output.",
        };

        private global::System.CommandLine.Option<int?> Duration { get; } = new(
            name: "duration")
        {
            Description = @"Duration of the video in seconds.",
        };

        private global::System.CommandLine.Option<global::G.CreateVideoFromImageRequestRatio?> Ratio { get; } = new(
            name: "ratio")
        {
            Description = @"Aspect ratio of the video.",
        };
        public CreateVideoFromImageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Start a new task to generate a video from an image prompt.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
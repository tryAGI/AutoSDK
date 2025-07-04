﻿//HintName: G.Commands.PostRemixImageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PostRemixImageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.InitialImageRequest imageRequest,
            byte[] imageFile,
            string imageFilename,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GenerateImageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.InitialImageRequest> ImageRequest { get; } = new(
            name: "imageRequest")
        {
            Description = @"A request to generate a new image using a provided image and a prompt.",
        };

        private global::System.CommandLine.Argument<byte[]> ImageFile { get; } = new(
            name: "imageFile")
        {
            Description = @"An image binary; only JPEG, WEBPs and PNGs are supported at this time",
        };

        private global::System.CommandLine.Argument<string> ImageFilename { get; } = new(
            name: "imageFilename")
        {
            Description = @"An image binary; only JPEG, WEBPs and PNGs are supported at this time",
        };

        public PostRemixImageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "post",
            description: @"A request to remix a provided image with Ideogram. Input images
are cropped to the chosen aspect ratio before being remixed.

Supported image formats include JPEG, PNG, and WEBP")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ImageRequest);
            Arguments.Add(ImageFile);
            Arguments.Add(ImageFilename);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var imageRequest = parseResult.GetRequiredValue(ImageRequest);
            var imageFile = parseResult.GetRequiredValue(ImageFile);
            var imageFilename = parseResult.GetRequiredValue(ImageFilename);

            Validate(
                parseResult: parseResult,
                imageRequest: imageRequest,
                imageFile: imageFile,
                imageFilename: imageFilename,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Generate.PostRemixImageAsync(
                imageRequest: imageRequest,
                imageFile: imageFile,
                imageFilename: imageFilename,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.ModelsGenerateFlux2FlexV1Flux2FlexPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsGenerateFlux2FlexV1Flux2FlexPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string prompt,
            bool? promptUpsampling,
            string? inputImage,
            string? inputImage2,
            string? inputImage3,
            string? inputImage4,
            string? inputImage5,
            string? inputImage6,
            string? inputImage7,
            string? inputImage8,
            string? inputImageBlobPath,
            int? seed,
            int? width,
            int? height,
            double? guidance,
            int? steps,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
            string? webhookUrl,
            string? webhookSecret,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"Text prompt for image generation.",
        };

        private global::System.CommandLine.Option<bool?> PromptUpsampling { get; } = new(
            name: "promptUpsampling")
        {
            Description = @"Whether to use prompt upsampling.",
        };

        private global::System.CommandLine.Option<string?> InputImage { get; } = new(
            name: "inputImage")
        {
            Description = @"Path to the input image.",
        };

        private global::System.CommandLine.Option<string?> InputImage2 { get; } = new(
            name: "inputImage2")
        {
            Description = @"Path to the second input image.",
        };

        private global::System.CommandLine.Option<string?> InputImage3 { get; } = new(
            name: "inputImage3")
        {
            Description = @"Path to the third input image.",
        };

        private global::System.CommandLine.Option<string?> InputImage4 { get; } = new(
            name: "inputImage4")
        {
            Description = @"Path to the fourth input image.",
        };

        private global::System.CommandLine.Option<string?> InputImage5 { get; } = new(
            name: "inputImage5")
        {
            Description = @"Path to the fifth input image.",
        };

        private global::System.CommandLine.Option<string?> InputImage6 { get; } = new(
            name: "inputImage6")
        {
            Description = @"Path to the sixth input image.",
        };

        private global::System.CommandLine.Option<string?> InputImage7 { get; } = new(
            name: "inputImage7")
        {
            Description = @"Path to the seventh input image.",
        };

        private global::System.CommandLine.Option<string?> InputImage8 { get; } = new(
            name: "inputImage8")
        {
            Description = @"Path to the eighth input image.",
        };

        private global::System.CommandLine.Option<string?> InputImageBlobPath { get; } = new(
            name: "inputImageBlobPath")
        {
            Description = @"Blob path to the input image.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Optional seed for reproducibility.",
        };

        private global::System.CommandLine.Option<int?> Width { get; } = new(
            name: "width")
        {
            Description = @"Width of the image",
        };

        private global::System.CommandLine.Option<int?> Height { get; } = new(
            name: "height")
        {
            Description = @"Height of the image",
        };

        private global::System.CommandLine.Option<double?> Guidance { get; } = new(
            name: "guidance")
        {
            Description = @"Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.",
        };

        private global::System.CommandLine.Option<int?> Steps { get; } = new(
            name: "steps")
        {
            Description = @"Number of steps for image generation. Higher steps lead to more detailed and realistic images.",
        };

        private global::System.CommandLine.Option<int?> SafetyTolerance { get; } = new(
            name: "safetyTolerance")
        {
            Description = @"Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.",
        };

        private global::System.CommandLine.Option<global::G.OutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> WebhookUrl { get; } = new(
            name: "webhookUrl")
        {
            Description = @"URL to receive webhook notifications",
        };

        private global::System.CommandLine.Option<string?> WebhookSecret { get; } = new(
            name: "webhookSecret")
        {
            Description = @"Optional secret for webhook signature verification",
        };


        public ModelsGenerateFlux2FlexV1Flux2FlexPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"Submits an image generation or editing task with FLUX.2 [FLEX].")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Prompt);
            Options.Add(PromptUpsampling);
            Options.Add(InputImage);
            Options.Add(InputImage2);
            Options.Add(InputImage3);
            Options.Add(InputImage4);
            Options.Add(InputImage5);
            Options.Add(InputImage6);
            Options.Add(InputImage7);
            Options.Add(InputImage8);
            Options.Add(InputImageBlobPath);
            Options.Add(Seed);
            Options.Add(Width);
            Options.Add(Height);
            Options.Add(Guidance);
            Options.Add(Steps);
            Options.Add(SafetyTolerance);
            Options.Add(OutputFormat);
            Options.Add(WebhookUrl);
            Options.Add(WebhookSecret);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var prompt = parseResult.GetRequiredValue(Prompt);
            var promptUpsampling = parseResult.GetRequiredValue(PromptUpsampling);
            var inputImage = parseResult.GetRequiredValue(InputImage);
            var inputImage2 = parseResult.GetRequiredValue(InputImage2);
            var inputImage3 = parseResult.GetRequiredValue(InputImage3);
            var inputImage4 = parseResult.GetRequiredValue(InputImage4);
            var inputImage5 = parseResult.GetRequiredValue(InputImage5);
            var inputImage6 = parseResult.GetRequiredValue(InputImage6);
            var inputImage7 = parseResult.GetRequiredValue(InputImage7);
            var inputImage8 = parseResult.GetRequiredValue(InputImage8);
            var inputImageBlobPath = parseResult.GetRequiredValue(InputImageBlobPath);
            var seed = parseResult.GetRequiredValue(Seed);
            var width = parseResult.GetRequiredValue(Width);
            var height = parseResult.GetRequiredValue(Height);
            var guidance = parseResult.GetRequiredValue(Guidance);
            var steps = parseResult.GetRequiredValue(Steps);
            var safetyTolerance = parseResult.GetRequiredValue(SafetyTolerance);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var webhookUrl = parseResult.GetRequiredValue(WebhookUrl);
            var webhookSecret = parseResult.GetRequiredValue(WebhookSecret);

            Validate(
                parseResult: parseResult,
                prompt: prompt,
                promptUpsampling: promptUpsampling,
                inputImage: inputImage,
                inputImage2: inputImage2,
                inputImage3: inputImage3,
                inputImage4: inputImage4,
                inputImage5: inputImage5,
                inputImage6: inputImage6,
                inputImage7: inputImage7,
                inputImage8: inputImage8,
                inputImageBlobPath: inputImageBlobPath,
                seed: seed,
                width: width,
                height: height,
                guidance: guidance,
                steps: steps,
                safetyTolerance: safetyTolerance,
                outputFormat: outputFormat,
                webhookUrl: webhookUrl,
                webhookSecret: webhookSecret,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.GenerateFlux2FlexV1Flux2FlexPostAsync(
                prompt: prompt,
                promptUpsampling: promptUpsampling,
                inputImage: inputImage,
                inputImage2: inputImage2,
                inputImage3: inputImage3,
                inputImage4: inputImage4,
                inputImage5: inputImage5,
                inputImage6: inputImage6,
                inputImage7: inputImage7,
                inputImage8: inputImage8,
                inputImageBlobPath: inputImageBlobPath,
                seed: seed,
                width: width,
                height: height,
                guidance: guidance,
                steps: steps,
                safetyTolerance: safetyTolerance,
                outputFormat: outputFormat,
                webhookUrl: webhookUrl,
                webhookSecret: webhookSecret,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.ModelsGenerateFlux11UltraV1FluxPro11UltraPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsGenerateFlux11UltraV1FluxPro11UltraPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? prompt,
            bool? promptUpsampling,
            int? seed,
            string? aspectRatio,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
            bool? raw,
            string? imagePrompt,
            double? imagePromptStrength,
            string? webhookUrl,
            string? webhookSecret,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The prompt to use for image generation.",
        };

        private global::System.CommandLine.Option<bool?> PromptUpsampling { get; } = new(
            name: "promptUpsampling")
        {
            Description = @"Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Optional seed for reproducibility. If not provided, a random seed will be used.",
        };

        private global::System.CommandLine.Option<string?> AspectRatio { get; } = new(
            name: "aspectRatio")
        {
            Description = @"Aspect ratio of the image between 21:9 and 9:21",
        };

        private global::System.CommandLine.Option<int?> SafetyTolerance { get; } = new(
            name: "safetyTolerance")
        {
            Description = @"Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.",
        };

        private global::System.CommandLine.Option<global::G.OutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = @"Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.",
        };

        private global::System.CommandLine.Option<bool?> Raw { get; } = new(
            name: "raw")
        {
            Description = @"Generate less processed, more natural-looking images",
        };

        private global::System.CommandLine.Option<string?> ImagePrompt { get; } = new(
            name: "imagePrompt")
        {
            Description = @"Optional image to remix in base64 format",
        };

        private global::System.CommandLine.Option<double?> ImagePromptStrength { get; } = new(
            name: "imagePromptStrength")
        {
            Description = @"Blend between the prompt and the image prompt",
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


        public ModelsGenerateFlux11UltraV1FluxPro11UltraPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"Submits an image generation task with FLUX 1.1 [pro] with ultra mode and optional raw mode.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Prompt);
            Options.Add(PromptUpsampling);
            Options.Add(Seed);
            Options.Add(AspectRatio);
            Options.Add(SafetyTolerance);
            Options.Add(OutputFormat);
            Options.Add(Raw);
            Options.Add(ImagePrompt);
            Options.Add(ImagePromptStrength);
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
            var seed = parseResult.GetRequiredValue(Seed);
            var aspectRatio = parseResult.GetRequiredValue(AspectRatio);
            var safetyTolerance = parseResult.GetRequiredValue(SafetyTolerance);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var raw = parseResult.GetRequiredValue(Raw);
            var imagePrompt = parseResult.GetRequiredValue(ImagePrompt);
            var imagePromptStrength = parseResult.GetRequiredValue(ImagePromptStrength);
            var webhookUrl = parseResult.GetRequiredValue(WebhookUrl);
            var webhookSecret = parseResult.GetRequiredValue(WebhookSecret);

            Validate(
                parseResult: parseResult,
                prompt: prompt,
                promptUpsampling: promptUpsampling,
                seed: seed,
                aspectRatio: aspectRatio,
                safetyTolerance: safetyTolerance,
                outputFormat: outputFormat,
                raw: raw,
                imagePrompt: imagePrompt,
                imagePromptStrength: imagePromptStrength,
                webhookUrl: webhookUrl,
                webhookSecret: webhookSecret,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.GenerateFlux11UltraV1FluxPro11UltraPostAsync(
                prompt: prompt,
                promptUpsampling: promptUpsampling,
                seed: seed,
                aspectRatio: aspectRatio,
                safetyTolerance: safetyTolerance,
                outputFormat: outputFormat,
                raw: raw,
                imagePrompt: imagePrompt,
                imagePromptStrength: imagePromptStrength,
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
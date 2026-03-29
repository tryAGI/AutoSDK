//HintName: G.Commands.ModelsFluxPro11V1FluxPro11PostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsFluxPro11V1FluxPro11PostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? prompt,
            string? imagePrompt,
            int? width,
            int? height,
            bool? promptUpsampling,
            int? seed,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
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
            Description = @"Text prompt for image generation.",
        };

        private global::System.CommandLine.Option<string?> ImagePrompt { get; } = new(
            name: "imagePrompt")
        {
            Description = @"Optional base64 encoded image to use with Flux Redux.",
        };

        private global::System.CommandLine.Option<int?> Width { get; } = new(
            name: "width")
        {
            Description = @"Width of the generated image in pixels. Must be a multiple of 32.",
        };

        private global::System.CommandLine.Option<int?> Height { get; } = new(
            name: "height")
        {
            Description = @"Height of the generated image in pixels. Must be a multiple of 32.",
        };

        private global::System.CommandLine.Option<bool?> PromptUpsampling { get; } = new(
            name: "promptUpsampling")
        {
            Description = @"Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Optional seed for reproducibility.",
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


        public ModelsFluxPro11V1FluxPro11PostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "flux",
            description: @"Submits an image generation task with FLUX 1.1 [pro].")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Prompt);
            Options.Add(ImagePrompt);
            Options.Add(Width);
            Options.Add(Height);
            Options.Add(PromptUpsampling);
            Options.Add(Seed);
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
            var imagePrompt = parseResult.GetRequiredValue(ImagePrompt);
            var width = parseResult.GetRequiredValue(Width);
            var height = parseResult.GetRequiredValue(Height);
            var promptUpsampling = parseResult.GetRequiredValue(PromptUpsampling);
            var seed = parseResult.GetRequiredValue(Seed);
            var safetyTolerance = parseResult.GetRequiredValue(SafetyTolerance);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var webhookUrl = parseResult.GetRequiredValue(WebhookUrl);
            var webhookSecret = parseResult.GetRequiredValue(WebhookSecret);

            Validate(
                parseResult: parseResult,
                prompt: prompt,
                imagePrompt: imagePrompt,
                width: width,
                height: height,
                promptUpsampling: promptUpsampling,
                seed: seed,
                safetyTolerance: safetyTolerance,
                outputFormat: outputFormat,
                webhookUrl: webhookUrl,
                webhookSecret: webhookSecret,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.FluxPro11V1FluxPro11PostAsync(
                prompt: prompt,
                imagePrompt: imagePrompt,
                width: width,
                height: height,
                promptUpsampling: promptUpsampling,
                seed: seed,
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
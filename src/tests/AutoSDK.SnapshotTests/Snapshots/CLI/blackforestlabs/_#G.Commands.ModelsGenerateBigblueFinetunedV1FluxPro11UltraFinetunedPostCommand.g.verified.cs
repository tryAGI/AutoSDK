//HintName: G.Commands.ModelsGenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsGenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string finetuneId,
            double? finetuneStrength,
            string? prompt,
            int? seed,
            string? aspectRatio,
            int? safetyTolerance,
            global::G.OutputFormat? outputFormat,
            string? imagePrompt,
            double? imagePromptStrength,
            bool? promptUpsampling,
            string? webhookUrl,
            string? webhookSecret,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FinetuneId { get; } = new(
            name: "finetuneId")
        {
            Description = @"ID of the fine-tuned model you want to use.",
        };

        private global::System.CommandLine.Option<double?> FinetuneStrength { get; } = new(
            name: "finetuneStrength")
        {
            Description = @"Strength of the fine-tuned model. 0.0 means no influence, 1.0 means full influence. Allowed values up to 2.0",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The prompt to use for image generation.",
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

        private global::System.CommandLine.Option<bool?> PromptUpsampling { get; } = new(
            name: "promptUpsampling")
        {
            Description = @"Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation",
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


        public ModelsGenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"Submits an image generation task with FLUX 1.1 [pro] finetune with ultra mode.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FinetuneId);
            Options.Add(FinetuneStrength);
            Options.Add(Prompt);
            Options.Add(Seed);
            Options.Add(AspectRatio);
            Options.Add(SafetyTolerance);
            Options.Add(OutputFormat);
            Options.Add(ImagePrompt);
            Options.Add(ImagePromptStrength);
            Options.Add(PromptUpsampling);
            Options.Add(WebhookUrl);
            Options.Add(WebhookSecret);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var finetuneId = parseResult.GetRequiredValue(FinetuneId);
            var finetuneStrength = parseResult.GetRequiredValue(FinetuneStrength);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var seed = parseResult.GetRequiredValue(Seed);
            var aspectRatio = parseResult.GetRequiredValue(AspectRatio);
            var safetyTolerance = parseResult.GetRequiredValue(SafetyTolerance);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var imagePrompt = parseResult.GetRequiredValue(ImagePrompt);
            var imagePromptStrength = parseResult.GetRequiredValue(ImagePromptStrength);
            var promptUpsampling = parseResult.GetRequiredValue(PromptUpsampling);
            var webhookUrl = parseResult.GetRequiredValue(WebhookUrl);
            var webhookSecret = parseResult.GetRequiredValue(WebhookSecret);

            Validate(
                parseResult: parseResult,
                finetuneId: finetuneId,
                finetuneStrength: finetuneStrength,
                prompt: prompt,
                seed: seed,
                aspectRatio: aspectRatio,
                safetyTolerance: safetyTolerance,
                outputFormat: outputFormat,
                imagePrompt: imagePrompt,
                imagePromptStrength: imagePromptStrength,
                promptUpsampling: promptUpsampling,
                webhookUrl: webhookUrl,
                webhookSecret: webhookSecret,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.GenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostAsync(
                finetuneId: finetuneId,
                finetuneStrength: finetuneStrength,
                prompt: prompt,
                seed: seed,
                aspectRatio: aspectRatio,
                safetyTolerance: safetyTolerance,
                outputFormat: outputFormat,
                imagePrompt: imagePrompt,
                imagePromptStrength: imagePromptStrength,
                promptUpsampling: promptUpsampling,
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
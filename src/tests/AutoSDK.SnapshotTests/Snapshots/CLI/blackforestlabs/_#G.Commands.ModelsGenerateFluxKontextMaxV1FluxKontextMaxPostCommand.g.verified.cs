//HintName: G.Commands.ModelsGenerateFluxKontextMaxV1FluxKontextMaxPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsGenerateFluxKontextMaxV1FluxKontextMaxPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string prompt,
            string? inputImage,
            string? inputImage2,
            string? inputImage3,
            string? inputImage4,
            int? seed,
            string? aspectRatio,
            global::G.OutputFormat? outputFormat,
            string? webhookUrl,
            string? webhookSecret,
            bool? promptUpsampling,
            int? safetyTolerance,
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

        private global::System.CommandLine.Option<string?> InputImage { get; } = new(
            name: "inputImage")
        {
            Description = @"Base64 encoded image or URL to use with Kontext.",
        };

        private global::System.CommandLine.Option<string?> InputImage2 { get; } = new(
            name: "inputImage2")
        {
            Description = @"Base64 encoded image or URL to use with Kontext. *Experimental Multiref*",
        };

        private global::System.CommandLine.Option<string?> InputImage3 { get; } = new(
            name: "inputImage3")
        {
            Description = @"Base64 encoded image or URL to use with Kontext. *Experimental Multiref*",
        };

        private global::System.CommandLine.Option<string?> InputImage4 { get; } = new(
            name: "inputImage4")
        {
            Description = @"Base64 encoded image or URL to use with Kontext. *Experimental Multiref*",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Optional seed for reproducibility.",
        };

        private global::System.CommandLine.Option<string?> AspectRatio { get; } = new(
            name: "aspectRatio")
        {
            Description = @"Aspect ratio of the image between 21:9 and 9:21",
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

        private global::System.CommandLine.Option<bool?> PromptUpsampling { get; } = new(
            name: "promptUpsampling")
        {
            Description = @"Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation.",
        };

        private global::System.CommandLine.Option<int?> SafetyTolerance { get; } = new(
            name: "safetyTolerance")
        {
            Description = @"Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.",
        };


        public ModelsGenerateFluxKontextMaxV1FluxKontextMaxPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Prompt);
            Options.Add(InputImage);
            Options.Add(InputImage2);
            Options.Add(InputImage3);
            Options.Add(InputImage4);
            Options.Add(Seed);
            Options.Add(AspectRatio);
            Options.Add(OutputFormat);
            Options.Add(WebhookUrl);
            Options.Add(WebhookSecret);
            Options.Add(PromptUpsampling);
            Options.Add(SafetyTolerance);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var prompt = parseResult.GetRequiredValue(Prompt);
            var inputImage = parseResult.GetRequiredValue(InputImage);
            var inputImage2 = parseResult.GetRequiredValue(InputImage2);
            var inputImage3 = parseResult.GetRequiredValue(InputImage3);
            var inputImage4 = parseResult.GetRequiredValue(InputImage4);
            var seed = parseResult.GetRequiredValue(Seed);
            var aspectRatio = parseResult.GetRequiredValue(AspectRatio);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var webhookUrl = parseResult.GetRequiredValue(WebhookUrl);
            var webhookSecret = parseResult.GetRequiredValue(WebhookSecret);
            var promptUpsampling = parseResult.GetRequiredValue(PromptUpsampling);
            var safetyTolerance = parseResult.GetRequiredValue(SafetyTolerance);

            Validate(
                parseResult: parseResult,
                prompt: prompt,
                inputImage: inputImage,
                inputImage2: inputImage2,
                inputImage3: inputImage3,
                inputImage4: inputImage4,
                seed: seed,
                aspectRatio: aspectRatio,
                outputFormat: outputFormat,
                webhookUrl: webhookUrl,
                webhookSecret: webhookSecret,
                promptUpsampling: promptUpsampling,
                safetyTolerance: safetyTolerance,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.GenerateFluxKontextMaxV1FluxKontextMaxPostAsync(
                prompt: prompt,
                inputImage: inputImage,
                inputImage2: inputImage2,
                inputImage3: inputImage3,
                inputImage4: inputImage4,
                seed: seed,
                aspectRatio: aspectRatio,
                outputFormat: outputFormat,
                webhookUrl: webhookUrl,
                webhookSecret: webhookSecret,
                promptUpsampling: promptUpsampling,
                safetyTolerance: safetyTolerance,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
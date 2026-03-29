//HintName: G.Commands.ModelsFillV1FluxPro10FillPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsFillV1FluxPro10FillPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string image,
            string? mask,
            string? prompt,
            int? steps,
            bool? promptUpsampling,
            int? seed,
            double? guidance,
            global::G.OutputFormat? outputFormat,
            int? safetyTolerance,
            string? webhookUrl,
            string? webhookSecret,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AnyOf<global::G.AsyncResponse, global::G.AsyncWebhookResponse> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Image { get; } = new(
            name: "image")
        {
            Description = @"A Base64-encoded string representing the image you wish to modify. Can contain alpha mask if desired.",
        };

        private global::System.CommandLine.Option<string?> Mask { get; } = new(
            name: "mask")
        {
            Description = @"A Base64-encoded string representing a mask for the areas you want to modify in the image. The mask should be the same dimensions as the image and in black and white. Black areas (0%) indicate no modification, while white areas (100%) specify areas for inpainting. Optional if you provide an alpha mask in the original image. Validation: The endpoint verifies that the dimensions of the mask match the original image.",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The description of the changes you want to make. This text guides the inpainting process, allowing you to specify features, styles, or modifications for the masked area.",
        };

        private global::System.CommandLine.Option<int?> Steps { get; } = new(
            name: "steps")
        {
            Description = @"Number of steps for the image generation process",
        };

        private global::System.CommandLine.Option<bool?> PromptUpsampling { get; } = new(
            name: "promptUpsampling")
        {
            Description = @"Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Optional seed for reproducibility",
        };

        private global::System.CommandLine.Option<double?> Guidance { get; } = new(
            name: "guidance")
        {
            Description = @"Guidance strength for the image generation process",
        };

        private global::System.CommandLine.Option<global::G.OutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = @"Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.",
        };

        private global::System.CommandLine.Option<int?> SafetyTolerance { get; } = new(
            name: "safetyTolerance")
        {
            Description = @"Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.",
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


        public ModelsFillV1FluxPro10FillPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "fill",
            description: @"Submits an image generation task with the FLUX.1 Fill [pro] model using an input image and mask. Mask can be applied to alpha channel or submitted as a separate image.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Image);
            Options.Add(Mask);
            Options.Add(Prompt);
            Options.Add(Steps);
            Options.Add(PromptUpsampling);
            Options.Add(Seed);
            Options.Add(Guidance);
            Options.Add(OutputFormat);
            Options.Add(SafetyTolerance);
            Options.Add(WebhookUrl);
            Options.Add(WebhookSecret);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var image = parseResult.GetRequiredValue(Image);
            var mask = parseResult.GetRequiredValue(Mask);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var steps = parseResult.GetRequiredValue(Steps);
            var promptUpsampling = parseResult.GetRequiredValue(PromptUpsampling);
            var seed = parseResult.GetRequiredValue(Seed);
            var guidance = parseResult.GetRequiredValue(Guidance);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var safetyTolerance = parseResult.GetRequiredValue(SafetyTolerance);
            var webhookUrl = parseResult.GetRequiredValue(WebhookUrl);
            var webhookSecret = parseResult.GetRequiredValue(WebhookSecret);

            Validate(
                parseResult: parseResult,
                image: image,
                mask: mask,
                prompt: prompt,
                steps: steps,
                promptUpsampling: promptUpsampling,
                seed: seed,
                guidance: guidance,
                outputFormat: outputFormat,
                safetyTolerance: safetyTolerance,
                webhookUrl: webhookUrl,
                webhookSecret: webhookSecret,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.FillV1FluxPro10FillPostAsync(
                image: image,
                mask: mask,
                prompt: prompt,
                steps: steps,
                promptUpsampling: promptUpsampling,
                seed: seed,
                guidance: guidance,
                outputFormat: outputFormat,
                safetyTolerance: safetyTolerance,
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
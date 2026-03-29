//HintName: G.Commands.ModelsExpandV1FluxPro10ExpandPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsExpandV1FluxPro10ExpandPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string image,
            int? top,
            int? bottom,
            int? left,
            int? right,
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
            Description = @"A Base64-encoded string representing the image you wish to expand.",
        };

        private global::System.CommandLine.Option<int?> Top { get; } = new(
            name: "top")
        {
            Description = @"Number of pixels to expand at the top of the image",
        };

        private global::System.CommandLine.Option<int?> Bottom { get; } = new(
            name: "bottom")
        {
            Description = @"Number of pixels to expand at the bottom of the image",
        };

        private global::System.CommandLine.Option<int?> Left { get; } = new(
            name: "left")
        {
            Description = @"Number of pixels to expand on the left side of the image",
        };

        private global::System.CommandLine.Option<int?> Right { get; } = new(
            name: "right")
        {
            Description = @"Number of pixels to expand on the right side of the image",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The description of the changes you want to make. This text guides the expansion process, allowing you to specify features, styles, or modifications for the expanded areas.",
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


        public ModelsExpandV1FluxPro10ExpandPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "expand",
            description: @"Submits an image expansion task that adds the specified number of pixels to any combination of sides (top, bottom, left, right) while maintaining context.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Image);
            Options.Add(Top);
            Options.Add(Bottom);
            Options.Add(Left);
            Options.Add(Right);
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
            var top = parseResult.GetRequiredValue(Top);
            var bottom = parseResult.GetRequiredValue(Bottom);
            var left = parseResult.GetRequiredValue(Left);
            var right = parseResult.GetRequiredValue(Right);
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
                top: top,
                bottom: bottom,
                left: left,
                right: right,
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
            var response = await _client.Models.ExpandV1FluxPro10ExpandPostAsync(
                image: image,
                top: top,
                bottom: bottom,
                left: left,
                right: right,
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
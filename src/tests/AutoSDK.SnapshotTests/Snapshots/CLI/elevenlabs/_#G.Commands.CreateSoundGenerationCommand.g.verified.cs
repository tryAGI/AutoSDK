//HintName: G.Commands.CreateSoundGenerationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateSoundGenerationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SoundGenerationV1SoundGenerationPostOutputFormat? outputFormat,
            string? xiApiKey,
            string text,
            double? durationSeconds,
            double? promptInfluence,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SoundGenerationV1SoundGenerationPostOutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> DurationSeconds { get; } = new(
            name: "durationSeconds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> PromptInfluence { get; } = new(
            name: "promptInfluence")
        {
            Description = "",
        };
        public CreateSoundGenerationCommand(G.IApi client) : base(
            name: "create",
            description: @"Turn text into sound effects for your videos, voice-overs or video games using the most advanced sound effects model in the world.")
        {
            _client = client;

            Arguments.Add(Text);
            Options.Add(OutputFormat);
            Options.Add(XiApiKey);
            Options.Add(DurationSeconds);
            Options.Add(PromptInfluence);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var text = parseResult.GetRequiredValue(Text);
            var durationSeconds = parseResult.GetRequiredValue(DurationSeconds);
            var promptInfluence = parseResult.GetRequiredValue(PromptInfluence);

            Validate(
                parseResult: parseResult,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                text: text,
                durationSeconds: durationSeconds,
                promptInfluence: promptInfluence,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SoundGeneration.CreateSoundGenerationAsync(
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                text: text,
                durationSeconds: durationSeconds,
                promptInfluence: promptInfluence,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.CreateProjectsPodcastCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateProjectsPodcastCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string modelId,
            global::G.AnyOf<global::G.PodcastConversationMode, global::G.PodcastBulletinMode> mode,
            global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>> source,
            global::G.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset? qualityPreset,
            global::G.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale? durationScale,
            string? language,
            global::System.Collections.Generic.IList<string>? highlights,
            string? callbackUrl,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PodcastProjectResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<global::G.PodcastConversationMode, global::G.PodcastBulletinMode>> Mode { get; } = new(
            name: "mode")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>>> Source { get; } = new(
            name: "source")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset?> QualityPreset { get; } = new(
            name: "qualityPreset")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale?> DurationScale { get; } = new(
            name: "durationScale")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Highlights { get; } = new(
            name: "highlights")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CallbackUrl { get; } = new(
            name: "callbackUrl")
        {
            Description = "",
        };
        public CreateProjectsPodcastCreateCommand(G.IApi client) : base(
            name: "create",
            description: @"Create and auto-convert a podcast project. Currently, the LLM cost is covered by us but you will still be charged for the audio generation. In the future, you will be charged for both the LLM and audio generation costs.")
        {
            _client = client;

            Arguments.Add(ModelId);
            Arguments.Add(Mode);
            Arguments.Add(Source);
            Options.Add(XiApiKey);
            Options.Add(QualityPreset);
            Options.Add(DurationScale);
            Options.Add(Language);
            Options.Add(Highlights);
            Options.Add(CallbackUrl);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var mode = parseResult.GetRequiredValue(Mode);
            var source = parseResult.GetRequiredValue(Source);
            var qualityPreset = parseResult.GetRequiredValue(QualityPreset);
            var durationScale = parseResult.GetRequiredValue(DurationScale);
            var language = parseResult.GetRequiredValue(Language);
            var highlights = parseResult.GetRequiredValue(Highlights);
            var callbackUrl = parseResult.GetRequiredValue(CallbackUrl);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                modelId: modelId,
                mode: mode,
                source: source,
                qualityPreset: qualityPreset,
                durationScale: durationScale,
                language: language,
                highlights: highlights,
                callbackUrl: callbackUrl,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.CreateProjectsPodcastCreateAsync(
                xiApiKey: xiApiKey,
                modelId: modelId,
                mode: mode,
                source: source,
                qualityPreset: qualityPreset,
                durationScale: durationScale,
                language: language,
                highlights: highlights,
                callbackUrl: callbackUrl,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.V2VideoTranslateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class V2VideoTranslateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? outputLanguage,
            double? speakerNum,
            string? title,
            bool? translateAudioOnly,
            string? videoUrl,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> OutputLanguage { get; } = new(
            name: "outputLanguage")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> SpeakerNum { get; } = new(
            name: "speakerNum")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> TranslateAudioOnly { get; } = new(
            name: "translateAudioOnly")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> VideoUrl { get; } = new(
            name: "videoUrl")
        {
            Description = @"",
        };
        public V2VideoTranslateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "v2video",
            description: @"Generated Video: [https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9](https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9)")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(OutputLanguage);
            Options.Add(SpeakerNum);
            Options.Add(Title);
            Options.Add(TranslateAudioOnly);
            Options.Add(VideoUrl);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var outputLanguage = parseResult.GetRequiredValue(OutputLanguage);
            var speakerNum = parseResult.GetRequiredValue(SpeakerNum);
            var title = parseResult.GetRequiredValue(Title);
            var translateAudioOnly = parseResult.GetRequiredValue(TranslateAudioOnly);
            var videoUrl = parseResult.GetRequiredValue(VideoUrl);

            Validate(
                parseResult: parseResult,
                outputLanguage: outputLanguage,
                speakerNum: speakerNum,
                title: title,
                translateAudioOnly: translateAudioOnly,
                videoUrl: videoUrl,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.VideoTranslateAPI.V2VideoTranslateAsync(
                outputLanguage: outputLanguage,
                speakerNum: speakerNum,
                title: title,
                translateAudioOnly: translateAudioOnly,
                videoUrl: videoUrl,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.CreateDubbingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateDubbingCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            byte[]? file,
            string? filename,
            byte[]? csvFile,
            string? csvFilename,
            byte[]? foregroundAudioFile,
            string? foregroundAudioFilename,
            byte[]? backgroundAudioFile,
            string? backgroundAudioFilename,
            string? name,
            string? sourceUrl,
            string? sourceLang,
            string? targetLang,
            int? numSpeakers,
            bool? watermark,
            int? startTime,
            int? endTime,
            bool? highestResolution,
            bool? dropBackgroundAudio,
            bool? useProfanityFilter,
            bool? dubbingStudio,
            bool? disableVoiceCloning,
            string? mode,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DoDubbingResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> CsvFile { get; } = new(
            name: "csvFile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CsvFilename { get; } = new(
            name: "csvFilename")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> ForegroundAudioFile { get; } = new(
            name: "foregroundAudioFile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ForegroundAudioFilename { get; } = new(
            name: "foregroundAudioFilename")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> BackgroundAudioFile { get; } = new(
            name: "backgroundAudioFile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> BackgroundAudioFilename { get; } = new(
            name: "backgroundAudioFilename")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SourceUrl { get; } = new(
            name: "sourceUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SourceLang { get; } = new(
            name: "sourceLang")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TargetLang { get; } = new(
            name: "targetLang")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> NumSpeakers { get; } = new(
            name: "numSpeakers")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Watermark { get; } = new(
            name: "watermark")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> StartTime { get; } = new(
            name: "startTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> EndTime { get; } = new(
            name: "endTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HighestResolution { get; } = new(
            name: "highestResolution")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DropBackgroundAudio { get; } = new(
            name: "dropBackgroundAudio")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> UseProfanityFilter { get; } = new(
            name: "useProfanityFilter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DubbingStudio { get; } = new(
            name: "dubbingStudio")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DisableVoiceCloning { get; } = new(
            name: "disableVoiceCloning")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Mode { get; } = new(
            name: "mode")
        {
            Description = "",
        };
        public CreateDubbingCommand(G.IApi client) : base(
            name: "create",
            description: @"Dubs a provided audio or video file into given language.")
        {
            _client = client;

            Options.Add(XiApiKey);
            Options.Add(File);
            Options.Add(Filename);
            Options.Add(CsvFile);
            Options.Add(CsvFilename);
            Options.Add(ForegroundAudioFile);
            Options.Add(ForegroundAudioFilename);
            Options.Add(BackgroundAudioFile);
            Options.Add(BackgroundAudioFilename);
            Options.Add(Name);
            Options.Add(SourceUrl);
            Options.Add(SourceLang);
            Options.Add(TargetLang);
            Options.Add(NumSpeakers);
            Options.Add(Watermark);
            Options.Add(StartTime);
            Options.Add(EndTime);
            Options.Add(HighestResolution);
            Options.Add(DropBackgroundAudio);
            Options.Add(UseProfanityFilter);
            Options.Add(DubbingStudio);
            Options.Add(DisableVoiceCloning);
            Options.Add(Mode);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var csvFile = parseResult.GetRequiredValue(CsvFile);
            var csvFilename = parseResult.GetRequiredValue(CsvFilename);
            var foregroundAudioFile = parseResult.GetRequiredValue(ForegroundAudioFile);
            var foregroundAudioFilename = parseResult.GetRequiredValue(ForegroundAudioFilename);
            var backgroundAudioFile = parseResult.GetRequiredValue(BackgroundAudioFile);
            var backgroundAudioFilename = parseResult.GetRequiredValue(BackgroundAudioFilename);
            var name = parseResult.GetRequiredValue(Name);
            var sourceUrl = parseResult.GetRequiredValue(SourceUrl);
            var sourceLang = parseResult.GetRequiredValue(SourceLang);
            var targetLang = parseResult.GetRequiredValue(TargetLang);
            var numSpeakers = parseResult.GetRequiredValue(NumSpeakers);
            var watermark = parseResult.GetRequiredValue(Watermark);
            var startTime = parseResult.GetRequiredValue(StartTime);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var highestResolution = parseResult.GetRequiredValue(HighestResolution);
            var dropBackgroundAudio = parseResult.GetRequiredValue(DropBackgroundAudio);
            var useProfanityFilter = parseResult.GetRequiredValue(UseProfanityFilter);
            var dubbingStudio = parseResult.GetRequiredValue(DubbingStudio);
            var disableVoiceCloning = parseResult.GetRequiredValue(DisableVoiceCloning);
            var mode = parseResult.GetRequiredValue(Mode);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                csvFile: csvFile,
                csvFilename: csvFilename,
                foregroundAudioFile: foregroundAudioFile,
                foregroundAudioFilename: foregroundAudioFilename,
                backgroundAudioFile: backgroundAudioFile,
                backgroundAudioFilename: backgroundAudioFilename,
                name: name,
                sourceUrl: sourceUrl,
                sourceLang: sourceLang,
                targetLang: targetLang,
                numSpeakers: numSpeakers,
                watermark: watermark,
                startTime: startTime,
                endTime: endTime,
                highestResolution: highestResolution,
                dropBackgroundAudio: dropBackgroundAudio,
                useProfanityFilter: useProfanityFilter,
                dubbingStudio: dubbingStudio,
                disableVoiceCloning: disableVoiceCloning,
                mode: mode,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.CreateDubbingAsync(
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                csvFile: csvFile,
                csvFilename: csvFilename,
                foregroundAudioFile: foregroundAudioFile,
                foregroundAudioFilename: foregroundAudioFilename,
                backgroundAudioFile: backgroundAudioFile,
                backgroundAudioFilename: backgroundAudioFilename,
                name: name,
                sourceUrl: sourceUrl,
                sourceLang: sourceLang,
                targetLang: targetLang,
                numSpeakers: numSpeakers,
                watermark: watermark,
                startTime: startTime,
                endTime: endTime,
                highestResolution: highestResolution,
                dropBackgroundAudio: dropBackgroundAudio,
                useProfanityFilter: useProfanityFilter,
                dubbingStudio: dubbingStudio,
                disableVoiceCloning: disableVoiceCloning,
                mode: mode,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
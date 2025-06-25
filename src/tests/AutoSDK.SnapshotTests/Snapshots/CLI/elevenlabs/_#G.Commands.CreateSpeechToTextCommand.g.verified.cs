//HintName: G.Commands.CreateSpeechToTextCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateSpeechToTextCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? enableLogging,
            string? xiApiKey,
            string modelId,
            byte[]? file,
            string? filename,
            string? languageCode,
            bool? tagAudioEvents,
            int? numSpeakers,
            global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? timestampsGranularity,
            bool? diarize,
            global::System.Collections.Generic.IList<global::G.ExportOptions>? additionalFormats,
            global::G.BodySpeechToTextV1SpeechToTextPostFileFormat? fileFormat,
            string? cloudStorageUrl,
            bool? webhook,
            double? temperature,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SpeechToTextChunkResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> EnableLogging { get; } = new(
            name: "enableLogging")
        {
            Description = "",
        };

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

        private global::System.CommandLine.Option<string?> LanguageCode { get; } = new(
            name: "languageCode")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> TagAudioEvents { get; } = new(
            name: "tagAudioEvents")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> NumSpeakers { get; } = new(
            name: "numSpeakers")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity?> TimestampsGranularity { get; } = new(
            name: "timestampsGranularity")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Diarize { get; } = new(
            name: "diarize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ExportOptions>?> AdditionalFormats { get; } = new(
            name: "additionalFormats")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodySpeechToTextV1SpeechToTextPostFileFormat?> FileFormat { get; } = new(
            name: "fileFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CloudStorageUrl { get; } = new(
            name: "cloudStorageUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Webhook { get; } = new(
            name: "webhook")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = "",
        };
        public CreateSpeechToTextCommand(G.IApi client) : base(
            name: "create",
            description: @"Transcribe an audio or video file. If webhook is set to true, the request will be processed asynchronously and results sent to configured webhooks.")
        {
            _client = client;

            Arguments.Add(ModelId);
            Options.Add(EnableLogging);
            Options.Add(XiApiKey);
            Options.Add(File);
            Options.Add(Filename);
            Options.Add(LanguageCode);
            Options.Add(TagAudioEvents);
            Options.Add(NumSpeakers);
            Options.Add(TimestampsGranularity);
            Options.Add(Diarize);
            Options.Add(AdditionalFormats);
            Options.Add(FileFormat);
            Options.Add(CloudStorageUrl);
            Options.Add(Webhook);
            Options.Add(Temperature);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var enableLogging = parseResult.GetRequiredValue(EnableLogging);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var languageCode = parseResult.GetRequiredValue(LanguageCode);
            var tagAudioEvents = parseResult.GetRequiredValue(TagAudioEvents);
            var numSpeakers = parseResult.GetRequiredValue(NumSpeakers);
            var timestampsGranularity = parseResult.GetRequiredValue(TimestampsGranularity);
            var diarize = parseResult.GetRequiredValue(Diarize);
            var additionalFormats = parseResult.GetRequiredValue(AdditionalFormats);
            var fileFormat = parseResult.GetRequiredValue(FileFormat);
            var cloudStorageUrl = parseResult.GetRequiredValue(CloudStorageUrl);
            var webhook = parseResult.GetRequiredValue(Webhook);
            var temperature = parseResult.GetRequiredValue(Temperature);

            Validate(
                parseResult: parseResult,
                enableLogging: enableLogging,
                xiApiKey: xiApiKey,
                modelId: modelId,
                file: file,
                filename: filename,
                languageCode: languageCode,
                tagAudioEvents: tagAudioEvents,
                numSpeakers: numSpeakers,
                timestampsGranularity: timestampsGranularity,
                diarize: diarize,
                additionalFormats: additionalFormats,
                fileFormat: fileFormat,
                cloudStorageUrl: cloudStorageUrl,
                webhook: webhook,
                temperature: temperature,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SpeechToText.CreateSpeechToTextAsync(
                enableLogging: enableLogging,
                xiApiKey: xiApiKey,
                modelId: modelId,
                file: file,
                filename: filename,
                languageCode: languageCode,
                tagAudioEvents: tagAudioEvents,
                numSpeakers: numSpeakers,
                timestampsGranularity: timestampsGranularity,
                diarize: diarize,
                additionalFormats: additionalFormats,
                fileFormat: fileFormat,
                cloudStorageUrl: cloudStorageUrl,
                webhook: webhook,
                temperature: temperature,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
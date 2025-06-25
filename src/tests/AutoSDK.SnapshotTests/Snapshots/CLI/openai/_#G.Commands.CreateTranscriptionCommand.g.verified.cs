//HintName: G.Commands.CreateTranscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTranscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] file,
            string filename,
            global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?> model,
            string? language,
            string? prompt,
            global::G.AudioResponseFormat? responseFormat,
            double? temperature,
            global::System.Collections.Generic.IList<global::G.TranscriptionInclude>? include,
            global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>? timestampGranularities,
            bool? stream,
            global::G.AnyOf<global::G.CreateTranscriptionRequestChunkingStrategy?, global::G.VadConfig>? chunkingStrategy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.CreateTranscriptionResponseJson, global::G.CreateTranscriptionResponseVerboseJson> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AudioResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.TranscriptionInclude>?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>?> TimestampGranularities { get; } = new(
            name: "timestampGranularities")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::G.CreateTranscriptionRequestChunkingStrategy?, global::G.VadConfig>?> ChunkingStrategy { get; } = new(
            name: "chunkingStrategy")
        {
            Description = "",
        };
        public CreateTranscriptionCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Arguments.Add(Model);
            Options.Add(Language);
            Options.Add(Prompt);
            Options.Add(ResponseFormat);
            Options.Add(Temperature);
            Options.Add(Include);
            Options.Add(TimestampGranularities);
            Options.Add(Stream);
            Options.Add(ChunkingStrategy);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var model = parseResult.GetRequiredValue(Model);
            var language = parseResult.GetRequiredValue(Language);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var include = parseResult.GetRequiredValue(Include);
            var timestampGranularities = parseResult.GetRequiredValue(TimestampGranularities);
            var stream = parseResult.GetRequiredValue(Stream);
            var chunkingStrategy = parseResult.GetRequiredValue(ChunkingStrategy);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                model: model,
                language: language,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                include: include,
                timestampGranularities: timestampGranularities,
                stream: stream,
                chunkingStrategy: chunkingStrategy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Audio.CreateTranscriptionAsync(
                file: file,
                filename: filename,
                model: model,
                language: language,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                include: include,
                timestampGranularities: timestampGranularities,
                stream: stream,
                chunkingStrategy: chunkingStrategy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
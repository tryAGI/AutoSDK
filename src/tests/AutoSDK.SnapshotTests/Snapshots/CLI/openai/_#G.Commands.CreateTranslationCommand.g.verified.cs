//HintName: G.Commands.CreateTranslationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTranslationCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] file,
            string filename,
            global::G.AnyOf<string, global::G.CreateTranslationRequestModel?> model,
            string? prompt,
            global::G.CreateTranslationRequestResponseFormat? responseFormat,
            double? temperature,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.CreateTranslationResponseJson, global::G.CreateTranslationResponseVerboseJson> response,
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

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateTranslationRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateTranslationRequestResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = "",
        };
        public CreateTranslationCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Arguments.Add(Model);
            Options.Add(Prompt);
            Options.Add(ResponseFormat);
            Options.Add(Temperature);

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
            var prompt = parseResult.GetRequiredValue(Prompt);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var temperature = parseResult.GetRequiredValue(Temperature);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                model: model,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Audio.CreateTranslationAsync(
                file: file,
                filename: filename,
                model: model,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
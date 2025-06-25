//HintName: G.Commands.CreateSpeechCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateSpeechCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::G.CreateSpeechRequestModel?> model,
            string input,
            string? instructions,
            global::G.VoiceIdsShared voice,
            global::G.CreateSpeechRequestResponseFormat? responseFormat,
            double? speed,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateSpeechRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Input { get; } = new(
            name: "input")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.VoiceIdsShared> Voice { get; } = new(
            name: "voice")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateSpeechRequestResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Speed { get; } = new(
            name: "speed")
        {
            Description = "",
        };
        public CreateSpeechCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Input);
            Arguments.Add(Voice);
            Options.Add(Instructions);
            Options.Add(ResponseFormat);
            Options.Add(Speed);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var input = parseResult.GetRequiredValue(Input);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var voice = parseResult.GetRequiredValue(Voice);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var speed = parseResult.GetRequiredValue(Speed);

            Validate(
                parseResult: parseResult,
                model: model,
                input: input,
                instructions: instructions,
                voice: voice,
                responseFormat: responseFormat,
                speed: speed,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Audio.CreateSpeechAsync(
                model: model,
                input: input,
                instructions: instructions,
                voice: voice,
                responseFormat: responseFormat,
                speed: speed,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
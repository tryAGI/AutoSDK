//HintName: G.Commands.GetVoiceGenerationGenerateVoiceParametersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVoiceGenerationGenerateVoiceParametersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoiceGenerationParameterResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        public GetVoiceGenerationGenerateVoiceParametersCommand(G.IApi client) : base(
            name: "get",
            description: @"Get possible parameters for the /v1/voice-generation/generate-voice endpoint.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VoiceGeneration.GetVoiceGenerationGenerateVoiceParametersAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
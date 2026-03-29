//HintName: G.Commands.GenerationApiModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerationApiModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ModelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);




        public GenerationApiModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "models",
            description: @"Retrieve a list of available models that can be used for text generation, chat completions, and other AI tasks.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


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
            var response = await _client.GenerationApi.ModelsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
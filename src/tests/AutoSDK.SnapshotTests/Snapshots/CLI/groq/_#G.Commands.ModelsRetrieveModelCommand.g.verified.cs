//HintName: G.Commands.ModelsRetrieveModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelsRetrieveModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Model6 response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to get",
        };



        public ModelsRetrieveModelCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "retrieve",
            description: @"Get a specific model")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.RetrieveModelAsync(
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
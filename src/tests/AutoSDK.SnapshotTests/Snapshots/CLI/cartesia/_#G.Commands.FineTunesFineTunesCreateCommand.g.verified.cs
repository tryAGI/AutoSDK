//HintName: G.Commands.FineTunesFineTunesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FineTunesFineTunesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FineTunesCreateCartesiaVersion cartesiaVersion,
            string name,
            string description,
            string language,
            string modelId,
            string dataset,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FineTune response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.FineTunesCreateCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"Name for the new fine-tune",
        };

        private new global::System.CommandLine.Argument<string> Description { get; } = new(
            name: "description")
        {
            Description = @"Description for the fine-tune",
        };

        private global::System.CommandLine.Argument<string> Language { get; } = new(
            name: "language")
        {
            Description = @"Language code for the fine-tune",
        };

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"Base model ID to fine-tune from",
        };

        private global::System.CommandLine.Argument<string> Dataset { get; } = new(
            name: "dataset")
        {
            Description = @"Dataset ID containing training files",
        };



        public FineTunesFineTunesCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "fine",
            description: @"Create a new fine-tune")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(Name);
            Arguments.Add(Description);
            Arguments.Add(Language);
            Arguments.Add(ModelId);
            Arguments.Add(Dataset);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var language = parseResult.GetRequiredValue(Language);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var dataset = parseResult.GetRequiredValue(Dataset);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                name: name,
                description: description,
                language: language,
                modelId: modelId,
                dataset: dataset,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTunes.FineTunesCreateAsync(
                cartesiaVersion: cartesiaVersion,
                name: name,
                description: description,
                language: language,
                modelId: modelId,
                dataset: dataset,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
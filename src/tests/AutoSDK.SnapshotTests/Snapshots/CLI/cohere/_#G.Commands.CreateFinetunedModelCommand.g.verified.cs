//HintName: G.Commands.CreateFinetunedModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateFinetunedModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            string name,
            global::G.Settings settings,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateFinetunedModelResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"FinetunedModel name (e.g. `foobar`).",
        };

        private global::System.CommandLine.Argument<global::G.Settings> Settings { get; } = new(
            name: "settings")
        {
            Description = @"FinetunedModel settings such as dataset, hyperparameters...",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };
        public CreateFinetunedModelCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Arguments.Add(Settings);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var name = parseResult.GetRequiredValue(Name);
            var settings = parseResult.GetRequiredValue(Settings);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                name: name,
                settings: settings,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Finetuning.CreateFinetunedModelAsync(
                xClientName: xClientName,
                name: name,
                settings: settings,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
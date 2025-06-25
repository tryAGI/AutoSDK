//HintName: G.Commands.PrivateModelsListModelsPrivateListGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PrivateModelsListModelsPrivateListGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.ModelOut> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public PrivateModelsListModelsPrivateListGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "private",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PrivateModelsListModelsPrivateListGetAsync(
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.CountTokensCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CountTokensCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelId,
            global::System.Collections.Generic.IList<global::G.Content>? contents,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CountTokensResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"The id of the model to use.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Content>?> Contents { get; } = new(
            name: "contents")
        {
            Description = @"Required. The input given to the model as a prompt.",
        };
        public CountTokensCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "count",
            description: @"Runs a model's tokenizer on input content and returns the token count.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelId);
            Options.Add(Contents);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelId = parseResult.GetRequiredValue(ModelId);
            var contents = parseResult.GetRequiredValue(Contents);

            Validate(
                parseResult: parseResult,
                modelId: modelId,
                contents: contents,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CountTokensAsync(
                modelId: modelId,
                contents: contents,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.ListModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            double? pageSize,
            string? pageToken,
            global::G.CompatibleEndpoint? endpoint,
            bool? defaultOnly,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListModelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<double?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.CompatibleEndpoint?> Endpoint { get; } = new(
            name: "endpoint")
        {
            Description = @"One of the Cohere API endpoints that the model can be used with.",
        };

        private global::System.CommandLine.Option<bool?> DefaultOnly { get; } = new(
            name: "defaultOnly")
        {
            Description = @"",
        };
        public ListModelsCommand(G.IApi client) : base(
            name: "list",
            description: @"Returns a list of models available for use. The list contains models from Cohere as well as your fine-tuned models.")
        {
            _client = client;

            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(Endpoint);
            Options.Add(DefaultOnly);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var endpoint = parseResult.GetRequiredValue(Endpoint);
            var defaultOnly = parseResult.GetRequiredValue(DefaultOnly);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                pageToken: pageToken,
                endpoint: endpoint,
                defaultOnly: defaultOnly,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.ListModelsAsync(
                pageSize: pageSize,
                pageToken: pageToken,
                endpoint: endpoint,
                defaultOnly: defaultOnly,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
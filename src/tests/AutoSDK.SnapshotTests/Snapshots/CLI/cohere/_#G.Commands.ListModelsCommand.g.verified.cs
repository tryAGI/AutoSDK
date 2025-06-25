//HintName: G.Commands.ListModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"Maximum number of models to include in a page
Defaults to `20`, min value of `1`, max value of `1000`.",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"Page token provided in the `next_page_token` field of a previous response.",
        };

        private global::System.CommandLine.Option<global::G.CompatibleEndpoint?> Endpoint { get; } = new(
            name: "endpoint")
        {
            Description = @"When provided, filters the list of models to only those that are compatible with the specified endpoint.",
        };

        private global::System.CommandLine.Option<bool?> DefaultOnly { get; } = new(
            name: "defaultOnly")
        {
            Description = @"When provided, filters the list of models to only the default model to the endpoint. This parameter is only valid when `endpoint` is provided.",
        };
        public ListModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Returns a list of models available for use. The list contains models from Cohere as well as your fine-tuned models.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
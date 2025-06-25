//HintName: G.Commands.ModelPublicServiceListModelDefinitionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceListModelDefinitionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            string? pageToken,
            global::G.ModelPublicServiceListModelDefinitionsView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListModelDefinitionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ModelPublicServiceListModelDefinitionsView?> View { get; } = new(
            name: "view")
        {
            Description = @"",
        };
        public ModelPublicServiceListModelDefinitionsCommand(G.IApi client) : base(
            name: "model",
            description: @"Returns a paginated list of model definitions.")
        {
            _client = client;

            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceListModelDefinitionsAsync(
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
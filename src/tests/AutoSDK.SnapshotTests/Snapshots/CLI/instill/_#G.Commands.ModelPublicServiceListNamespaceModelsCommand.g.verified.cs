//HintName: G.Commands.ModelPublicServiceListNamespaceModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceListNamespaceModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            int? pageSize,
            string? pageToken,
            global::G.ModelPublicServiceListNamespaceModelsView? view,
            bool? showDeleted,
            string? filter,
            global::G.ModelPublicServiceListNamespaceModelsVisibility? visibility,
            string? orderBy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListNamespaceModelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ModelPublicServiceListNamespaceModelsView?> View { get; } = new(
            name: "view")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ShowDeleted { get; } = new(
            name: "showDeleted")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ModelPublicServiceListNamespaceModelsVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = "",
        };
        public ModelPublicServiceListNamespaceModelsCommand(G.IApi client) : base(
            name: "model",
            description: @"Returns a paginated list of models.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(View);
            Options.Add(ShowDeleted);
            Options.Add(Filter);
            Options.Add(Visibility);
            Options.Add(OrderBy);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var view = parseResult.GetRequiredValue(View);
            var showDeleted = parseResult.GetRequiredValue(ShowDeleted);
            var filter = parseResult.GetRequiredValue(Filter);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var orderBy = parseResult.GetRequiredValue(OrderBy);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                showDeleted: showDeleted,
                filter: filter,
                visibility: visibility,
                orderBy: orderBy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceListNamespaceModelsAsync(
                namespaceId: namespaceId,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                showDeleted: showDeleted,
                filter: filter,
                visibility: visibility,
                orderBy: orderBy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
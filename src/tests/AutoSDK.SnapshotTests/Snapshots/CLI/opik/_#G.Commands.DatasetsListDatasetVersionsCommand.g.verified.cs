//HintName: G.Commands.DatasetsListDatasetVersionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsListDatasetVersionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetVersionPagePublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Size { get; } = new(
            name: "size")
        {
            Description = @"",
        };


        public DatasetsListDatasetVersionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Get paginated list of versions for a dataset, ordered by creation time (newest first)")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Page);
            Options.Add(Size);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.ListDatasetVersionsAsync(
                page: page,
                size: size,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
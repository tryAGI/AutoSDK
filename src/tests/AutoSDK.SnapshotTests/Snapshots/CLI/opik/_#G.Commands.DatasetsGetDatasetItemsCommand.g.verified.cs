//HintName: G.Commands.DatasetsGetDatasetItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsGetDatasetItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            int? page,
            int? size,
            string? version,
            string? filters,
            bool? truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetItemPagePublic response,
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

        private global::System.CommandLine.Option<string?> Version { get; } = new(
            name: "version")
        {
            Description = @"Version hash or tag to fetch specific dataset version",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"Truncate image included in either input, output or metadata",
        };


        public DatasetsGetDatasetItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get dataset items")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Page);
            Options.Add(Size);
            Options.Add(Version);
            Options.Add(Filters);
            Options.Add(Truncate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var version = parseResult.GetRequiredValue(Version);
            var filters = parseResult.GetRequiredValue(Filters);
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                id: id,
                page: page,
                size: size,
                version: version,
                filters: filters,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.GetDatasetItemsAsync(
                id: id,
                page: page,
                size: size,
                version: version,
                filters: filters,
                truncate: truncate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.DatasetsFindDatasetItemsWithExperimentItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsFindDatasetItemsWithExperimentItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            int? page,
            int? size,
            string experimentIds,
            string? filters,
            string? sorting,
            string? search,
            bool? truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetItemPageCompare response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ExperimentIds { get; } = new(
            name: "experimentIds")
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

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Sorting { get; } = new(
            name: "sorting")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"Truncate image included in either input, output or metadata",
        };


        public DatasetsFindDatasetItemsWithExperimentItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find dataset items with experiment items")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(ExperimentIds);
            Options.Add(Page);
            Options.Add(Size);
            Options.Add(Filters);
            Options.Add(Sorting);
            Options.Add(Search);
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
            var experimentIds = parseResult.GetRequiredValue(ExperimentIds);
            var filters = parseResult.GetRequiredValue(Filters);
            var sorting = parseResult.GetRequiredValue(Sorting);
            var search = parseResult.GetRequiredValue(Search);
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                id: id,
                page: page,
                size: size,
                experimentIds: experimentIds,
                filters: filters,
                sorting: sorting,
                search: search,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.FindDatasetItemsWithExperimentItemsAsync(
                id: id,
                page: page,
                size: size,
                experimentIds: experimentIds,
                filters: filters,
                sorting: sorting,
                search: search,
                truncate: truncate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
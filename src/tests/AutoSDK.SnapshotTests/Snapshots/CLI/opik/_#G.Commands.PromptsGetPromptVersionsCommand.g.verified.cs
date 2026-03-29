//HintName: G.Commands.PromptsGetPromptVersionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsGetPromptVersionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            int? page,
            int? size,
            string? search,
            string? sorting,
            string? filters,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PromptVersionPagePublic response,
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

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = @"Search text to find in template or change description fields",
        };

        private global::System.CommandLine.Option<string?> Sorting { get; } = new(
            name: "sorting")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };


        public PromptsGetPromptVersionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get prompt versions")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Page);
            Options.Add(Size);
            Options.Add(Search);
            Options.Add(Sorting);
            Options.Add(Filters);

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
            var search = parseResult.GetRequiredValue(Search);
            var sorting = parseResult.GetRequiredValue(Sorting);
            var filters = parseResult.GetRequiredValue(Filters);

            Validate(
                parseResult: parseResult,
                id: id,
                page: page,
                size: size,
                search: search,
                sorting: sorting,
                filters: filters,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Prompts.GetPromptVersionsAsync(
                id: id,
                page: page,
                size: size,
                search: search,
                sorting: sorting,
                filters: filters,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
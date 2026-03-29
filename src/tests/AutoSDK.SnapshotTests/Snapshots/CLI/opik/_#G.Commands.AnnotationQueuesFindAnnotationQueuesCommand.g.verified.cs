//HintName: G.Commands.AnnotationQueuesFindAnnotationQueuesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnnotationQueuesFindAnnotationQueuesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            string? name,
            string? filters,
            string? sorting,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AnnotationQueuePagePublic response,
            global::System.Threading.CancellationToken cancellationToken);


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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Filter annotation queues by name (partial match, case insensitive)",
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


        public AnnotationQueuesFindAnnotationQueuesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find annotation queues with filtering and sorting")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(Size);
            Options.Add(Name);
            Options.Add(Filters);
            Options.Add(Sorting);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var name = parseResult.GetRequiredValue(Name);
            var filters = parseResult.GetRequiredValue(Filters);
            var sorting = parseResult.GetRequiredValue(Sorting);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                name: name,
                filters: filters,
                sorting: sorting,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AnnotationQueues.FindAnnotationQueuesAsync(
                page: page,
                size: size,
                name: name,
                filters: filters,
                sorting: sorting,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.TracesGetTraceThreadsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesGetTraceThreadsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            string? projectName,
            global::System.Guid? projectId,
            bool? truncate,
            bool? stripAttachments,
            string? filters,
            string? sorting,
            string? search,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TraceThreadPage response,
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

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"Truncate input, output and metadata to slim payloads",
        };

        private global::System.CommandLine.Option<bool?> StripAttachments { get; } = new(
            name: "stripAttachments")
        {
            Description = @"If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments",
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
            Description = @"Full-text search across thread fields",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> FromTime { get; } = new(
            name: "fromTime")
        {
            Description = @"Filter trace threads created from this time (ISO-8601 format).",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ToTime { get; } = new(
            name: "toTime")
        {
            Description = @"Filter trace threads created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.",
        };


        public TracesGetTraceThreadsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get trace threads")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(Size);
            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(Truncate);
            Options.Add(StripAttachments);
            Options.Add(Filters);
            Options.Add(Sorting);
            Options.Add(Search);
            Options.Add(FromTime);
            Options.Add(ToTime);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var truncate = parseResult.GetRequiredValue(Truncate);
            var stripAttachments = parseResult.GetRequiredValue(StripAttachments);
            var filters = parseResult.GetRequiredValue(Filters);
            var sorting = parseResult.GetRequiredValue(Sorting);
            var search = parseResult.GetRequiredValue(Search);
            var fromTime = parseResult.GetRequiredValue(FromTime);
            var toTime = parseResult.GetRequiredValue(ToTime);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                projectName: projectName,
                projectId: projectId,
                truncate: truncate,
                stripAttachments: stripAttachments,
                filters: filters,
                sorting: sorting,
                search: search,
                fromTime: fromTime,
                toTime: toTime,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Traces.GetTraceThreadsAsync(
                page: page,
                size: size,
                projectName: projectName,
                projectId: projectId,
                truncate: truncate,
                stripAttachments: stripAttachments,
                filters: filters,
                sorting: sorting,
                search: search,
                fromTime: fromTime,
                toTime: toTime,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
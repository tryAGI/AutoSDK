//HintName: G.Commands.SpansGetSpansByProjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansGetSpansByProjectCommand : global::System.CommandLine.Command
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
            global::System.Guid? traceId,
            global::G.GetSpansByProjectType? type,
            string? filters,
            bool? truncate,
            bool? stripAttachments,
            string? sorting,
            string? exclude,
            string? search,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SpanPagePublic response,
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

        private global::System.CommandLine.Option<global::System.Guid?> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GetSpansByProjectType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
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

        private global::System.CommandLine.Option<string?> Sorting { get; } = new(
            name: "sorting")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Exclude { get; } = new(
            name: "exclude")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = @"Full-text search across span fields",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> FromTime { get; } = new(
            name: "fromTime")
        {
            Description = @"Filter spans created from this time (ISO-8601 format).",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ToTime { get; } = new(
            name: "toTime")
        {
            Description = @"Filter spans created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.",
        };


        public SpansGetSpansByProjectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get spans by project_name or project_id and optionally by trace_id and/or type")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(Size);
            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(TraceId);
            Options.Add(Type);
            Options.Add(Filters);
            Options.Add(Truncate);
            Options.Add(StripAttachments);
            Options.Add(Sorting);
            Options.Add(Exclude);
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
            var traceId = parseResult.GetRequiredValue(TraceId);
            var type = parseResult.GetRequiredValue(Type);
            var filters = parseResult.GetRequiredValue(Filters);
            var truncate = parseResult.GetRequiredValue(Truncate);
            var stripAttachments = parseResult.GetRequiredValue(StripAttachments);
            var sorting = parseResult.GetRequiredValue(Sorting);
            var exclude = parseResult.GetRequiredValue(Exclude);
            var search = parseResult.GetRequiredValue(Search);
            var fromTime = parseResult.GetRequiredValue(FromTime);
            var toTime = parseResult.GetRequiredValue(ToTime);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                projectName: projectName,
                projectId: projectId,
                traceId: traceId,
                type: type,
                filters: filters,
                truncate: truncate,
                stripAttachments: stripAttachments,
                sorting: sorting,
                exclude: exclude,
                search: search,
                fromTime: fromTime,
                toTime: toTime,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Spans.GetSpansByProjectAsync(
                page: page,
                size: size,
                projectName: projectName,
                projectId: projectId,
                traceId: traceId,
                type: type,
                filters: filters,
                truncate: truncate,
                stripAttachments: stripAttachments,
                sorting: sorting,
                exclude: exclude,
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
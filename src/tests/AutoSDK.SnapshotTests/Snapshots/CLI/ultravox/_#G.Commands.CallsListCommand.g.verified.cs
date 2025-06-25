//HintName: G.Commands.CallsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? cursor,
            string? durationMax,
            string? durationMin,
            global::System.DateTime? fromDate,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            int? pageSize,
            string? search,
            string? sort,
            global::System.DateTime? toDate,
            global::System.Guid? voiceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PaginatedCallList response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = @"The pagination cursor value.",
        };

        private global::System.CommandLine.Option<string?> DurationMax { get; } = new(
            name: "durationMax")
        {
            Description = @"Maximum duration of calls",
        };

        private global::System.CommandLine.Option<string?> DurationMin { get; } = new(
            name: "durationMin")
        {
            Description = @"Minimum duration of calls",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> FromDate { get; } = new(
            name: "fromDate")
        {
            Description = @"Start date (inclusive) for filtering calls by creation date",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Filter calls by metadata. Use metadata.key=value to filter by specific key-value pairs.",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"Number of results to return per page.",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = @"The search string used to filter results",
        };

        private global::System.CommandLine.Option<string?> Sort { get; } = new(
            name: "sort")
        {
            Description = @"Which field to use when ordering the results.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ToDate { get; } = new(
            name: "toDate")
        {
            Description = @"End date (inclusive) for filtering calls by creation date",
        };

        private global::System.CommandLine.Option<global::System.Guid?> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = @"Filter calls by the associated voice ID",
        };
        public CallsListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "calls",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Cursor);
            Options.Add(DurationMax);
            Options.Add(DurationMin);
            Options.Add(FromDate);
            Options.Add(Metadata);
            Options.Add(PageSize);
            Options.Add(Search);
            Options.Add(Sort);
            Options.Add(ToDate);
            Options.Add(VoiceId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cursor = parseResult.GetRequiredValue(Cursor);
            var durationMax = parseResult.GetRequiredValue(DurationMax);
            var durationMin = parseResult.GetRequiredValue(DurationMin);
            var fromDate = parseResult.GetRequiredValue(FromDate);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var search = parseResult.GetRequiredValue(Search);
            var sort = parseResult.GetRequiredValue(Sort);
            var toDate = parseResult.GetRequiredValue(ToDate);
            var voiceId = parseResult.GetRequiredValue(VoiceId);

            Validate(
                parseResult: parseResult,
                cursor: cursor,
                durationMax: durationMax,
                durationMin: durationMin,
                fromDate: fromDate,
                metadata: metadata,
                pageSize: pageSize,
                search: search,
                sort: sort,
                toDate: toDate,
                voiceId: voiceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Calls.CallsListAsync(
                cursor: cursor,
                durationMax: durationMax,
                durationMin: durationMin,
                fromDate: fromDate,
                metadata: metadata,
                pageSize: pageSize,
                search: search,
                sort: sort,
                toDate: toDate,
                voiceId: voiceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
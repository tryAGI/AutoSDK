//HintName: G.Commands.ListTranscriptsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListTranscriptsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            long? limit,
            global::G.TranscriptStatus? status,
            global::System.DateTime? createdOn,
            global::System.Guid? beforeId,
            global::System.Guid? afterId,
            bool? throttledOnly,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TranscriptList response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<long?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Maximum amount of transcripts to retrieve",
        };

        private global::System.CommandLine.Option<global::G.TranscriptStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"Filter by transcript status",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> CreatedOn { get; } = new(
            name: "createdOn")
        {
            Description = @"Only get transcripts created on this date",
        };

        private global::System.CommandLine.Option<global::System.Guid?> BeforeId { get; } = new(
            name: "beforeId")
        {
            Description = @"Get transcripts that were created before this transcript ID",
        };

        private global::System.CommandLine.Option<global::System.Guid?> AfterId { get; } = new(
            name: "afterId")
        {
            Description = @"Get transcripts that were created after this transcript ID",
        };

        private global::System.CommandLine.Option<bool?> ThrottledOnly { get; } = new(
            name: "throttledOnly")
        {
            Description = @"Only get throttled transcripts, overrides the status filter",
        };
        public ListTranscriptsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Retrieve a list of transcripts you created.
Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Limit);
            Options.Add(Status);
            Options.Add(CreatedOn);
            Options.Add(BeforeId);
            Options.Add(AfterId);
            Options.Add(ThrottledOnly);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var limit = parseResult.GetRequiredValue(Limit);
            var status = parseResult.GetRequiredValue(Status);
            var createdOn = parseResult.GetRequiredValue(CreatedOn);
            var beforeId = parseResult.GetRequiredValue(BeforeId);
            var afterId = parseResult.GetRequiredValue(AfterId);
            var throttledOnly = parseResult.GetRequiredValue(ThrottledOnly);

            Validate(
                parseResult: parseResult,
                limit: limit,
                status: status,
                createdOn: createdOn,
                beforeId: beforeId,
                afterId: afterId,
                throttledOnly: throttledOnly,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Transcript.ListTranscriptsAsync(
                limit: limit,
                status: status,
                createdOn: createdOn,
                beforeId: beforeId,
                afterId: afterId,
                throttledOnly: throttledOnly,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
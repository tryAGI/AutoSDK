//HintName: G.Commands.UsageCodeInterpreterSessionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsageCodeInterpreterSessionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int startTime,
            int? endTime,
            global::G.UsageCodeInterpreterSessionsBucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::G.UsageCodeInterpreterSessionsGroupByItem>? groupBy,
            int? limit,
            string? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UsageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> StartTime { get; } = new(
            name: "startTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> EndTime { get; } = new(
            name: "endTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UsageCodeInterpreterSessionsBucketWidth?> BucketWidth { get; } = new(
            name: "bucketWidth")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ProjectIds { get; } = new(
            name: "projectIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UsageCodeInterpreterSessionsGroupByItem>?> GroupBy { get; } = new(
            name: "groupBy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };
        public UsageCodeInterpreterSessionsCommand(G.IOpenAiClient client) : base(
            name: "usage",
            description: @"")
        {
            _client = client;

            Arguments.Add(StartTime);
            Options.Add(EndTime);
            Options.Add(BucketWidth);
            Options.Add(ProjectIds);
            Options.Add(GroupBy);
            Options.Add(Limit);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var startTime = parseResult.GetRequiredValue(StartTime);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var bucketWidth = parseResult.GetRequiredValue(BucketWidth);
            var projectIds = parseResult.GetRequiredValue(ProjectIds);
            var groupBy = parseResult.GetRequiredValue(GroupBy);
            var limit = parseResult.GetRequiredValue(Limit);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                startTime: startTime,
                endTime: endTime,
                bucketWidth: bucketWidth,
                projectIds: projectIds,
                groupBy: groupBy,
                limit: limit,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Usage.UsageCodeInterpreterSessionsAsync(
                startTime: startTime,
                endTime: endTime,
                bucketWidth: bucketWidth,
                projectIds: projectIds,
                groupBy: groupBy,
                limit: limit,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}
//HintName: G.Commands.UsageImagesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsageImagesCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int startTime,
            int? endTime,
            global::G.UsageImagesBucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<global::G.UsageImagesSource>? sources,
            global::System.Collections.Generic.IList<global::G.UsageImagesSize>? sizes,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? apiKeyIds,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::G.UsageImagesGroupByItem>? groupBy,
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

        private global::System.CommandLine.Option<global::G.UsageImagesBucketWidth?> BucketWidth { get; } = new(
            name: "bucketWidth")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UsageImagesSource>?> Sources { get; } = new(
            name: "sources")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UsageImagesSize>?> Sizes { get; } = new(
            name: "sizes")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ProjectIds { get; } = new(
            name: "projectIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
            name: "userIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ApiKeyIds { get; } = new(
            name: "apiKeyIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
            name: "models")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.UsageImagesGroupByItem>?> GroupBy { get; } = new(
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
        public UsageImagesCommand(G.IOpenAiClient client) : base(
            name: "usage",
            description: @"")
        {
            _client = client;

            Arguments.Add(StartTime);
            Options.Add(EndTime);
            Options.Add(BucketWidth);
            Options.Add(Sources);
            Options.Add(Sizes);
            Options.Add(ProjectIds);
            Options.Add(UserIds);
            Options.Add(ApiKeyIds);
            Options.Add(Models);
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
            var sources = parseResult.GetRequiredValue(Sources);
            var sizes = parseResult.GetRequiredValue(Sizes);
            var projectIds = parseResult.GetRequiredValue(ProjectIds);
            var userIds = parseResult.GetRequiredValue(UserIds);
            var apiKeyIds = parseResult.GetRequiredValue(ApiKeyIds);
            var models = parseResult.GetRequiredValue(Models);
            var groupBy = parseResult.GetRequiredValue(GroupBy);
            var limit = parseResult.GetRequiredValue(Limit);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                startTime: startTime,
                endTime: endTime,
                bucketWidth: bucketWidth,
                sources: sources,
                sizes: sizes,
                projectIds: projectIds,
                userIds: userIds,
                apiKeyIds: apiKeyIds,
                models: models,
                groupBy: groupBy,
                limit: limit,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Usage.UsageImagesAsync(
                startTime: startTime,
                endTime: endTime,
                bucketWidth: bucketWidth,
                sources: sources,
                sizes: sizes,
                projectIds: projectIds,
                userIds: userIds,
                apiKeyIds: apiKeyIds,
                models: models,
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